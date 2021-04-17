using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

struct ClassProperties
{
	public Type classType;
	public string[] props;
	public string[] links;

	public ClassProperties(Type classType, string[] props, string[] links = null)
	{
		this.classType = classType;
		this.props = props;
		this.links = links;
	}
}

public class ExportImport : MonoBehaviour
{
	public string[] textureNames = new string[0];
	public Sprite[] textures = new Sprite[0];
	public string[] fontNames = new string[0];
	public Font[] fonts = new Font[0];


	private int uid = 0;
	private Dictionary<object, int> objectToUidLookup = new Dictionary<object, int>();
	private Dictionary<int, object> uidToObjectLookup = new Dictionary<int, object>();

	private List<Action> afterCreationDelegates = new List<Action>();

	public Transform test;
	// Start is called before the first frame update
	void Start()
	{
		var d = Serialize(this.gameObject);

		string json = JsonSerialize(d);

		var text = @"namespace LansUItest { class UIData { public static string data = @""" + json.Replace("\"", "\"\"") + "\"; } }";


		File.WriteAllText("UIData.cs", text);

		Debug.Log(json);

		var v = JsonDeserialize(json);

		var g = Deserialize(v, test);
	}

	void SerializeLinks(Dictionary<string, object> data, object o, String[] names)
	{
		var t = o.GetType();
		foreach (var name in names)
		{
			var v = t.GetProperty(name).GetValue(o);
			afterCreationDelegates.Add(() =>
			{
				if (objectToUidLookup.ContainsKey(v))
				{
					data.Add(name, objectToUidLookup[v]);
				}
				else
				{
					throw new Exception($"objectToUidLookup does not contain value {v} for name: {name} of type {t}");
				}
			});
		}
	}

	void SerializeFields(Dictionary<string, object> data, object o, String[] names)
	{
		var t = o.GetType();

		foreach (var name in names)
		{
			var v = t.GetProperty(name).GetValue(o);
			var tv = v.GetType();
			if (tv.IsEnum)
			{
				data.Add(name, (int)v);
			}
			else if (tv == typeof(int))
			{
				data.Add(name, v);
			}
			else if (tv == typeof(string))
			{
				data.Add(name, v);
			}
			else if (tv == typeof(float))
			{
				data.Add(name, v);
			}
			else if (tv == typeof(bool))
			{
				data.Add(name, v);
			}
			else if (tv == typeof(bool))
			{
				data.Add(name, v);
			}
			else if (tv == typeof(Vector2))
			{
				var vvv = (Vector2)v;
				data.Add(name, new float[] { vvv.x, vvv.y });
			}
			else if (tv == typeof(Vector3))
			{
				var vvv = (Vector3)v;
				data.Add(name, new float[] { vvv.x, vvv.y, vvv.z });
			}
			else if (tv == typeof(RectOffset))
			{
				var vvv = (RectOffset)v;
				data.Add(name, new int[] { vvv.left, vvv.bottom, vvv.top, vvv.right });
			}
			else if (tv == typeof(Color))
			{
				var vvv = (Color)v;
				data.Add(name, new float[] { vvv.r, vvv.g, vvv.b, vvv.a });
			}
			else if (typeof(Sprite).IsAssignableFrom(tv))
			{
				var vvv = (Sprite)v;
				if (vvv != null)
				{
					data.Add(name, vvv.name);
				}
			}
			else if (typeof(Font).IsAssignableFrom(tv))
			{
				var vvv = (Font)v;
				data.Add(name, vvv.name);
			}
			else if (tv == typeof(UnityEngine.UI.ColorBlock))
			{
				var vvv = (UnityEngine.UI.ColorBlock)v;
				var index = 0;
				var dataValues = new float[5 * 4 + 2];

				dataValues[index * 4 + 0] = vvv.normalColor.r;
				dataValues[index * 4 + 1] = vvv.normalColor.g;
				dataValues[index * 4 + 2] = vvv.normalColor.b;
				dataValues[index * 4 + 3] = vvv.normalColor.a;
				index++;
				dataValues[index * 4 + 0] = vvv.highlightedColor.r;
				dataValues[index * 4 + 1] = vvv.highlightedColor.g;
				dataValues[index * 4 + 2] = vvv.highlightedColor.b;
				dataValues[index * 4 + 3] = vvv.highlightedColor.a;
				index++;
				dataValues[index * 4 + 0] = vvv.pressedColor.r;
				dataValues[index * 4 + 1] = vvv.pressedColor.g;
				dataValues[index * 4 + 2] = vvv.pressedColor.b;
				dataValues[index * 4 + 3] = vvv.pressedColor.a;
				index++;
				dataValues[index * 4 + 0] = vvv.selectedColor.r;
				dataValues[index * 4 + 1] = vvv.selectedColor.g;
				dataValues[index * 4 + 2] = vvv.selectedColor.b;
				dataValues[index * 4 + 3] = vvv.selectedColor.a;
				index++;
				dataValues[index * 4 + 0] = vvv.disabledColor.r;
				dataValues[index * 4 + 1] = vvv.disabledColor.g;
				dataValues[index * 4 + 2] = vvv.disabledColor.b;
				dataValues[index * 4 + 3] = vvv.disabledColor.a;
				index++;
				dataValues[index * 4 + 0] = vvv.colorMultiplier;
				dataValues[index * 4 + 1] = vvv.fadeDuration;

				data.Add(name, dataValues);
			}
			else
			{
				throw new Exception($"Error {name} is unknown type {tv}");
			}
		}
	}

	void DeserializeLinks(Dictionary<string, object> data, object o)
	{
		var t = o.GetType();

		foreach (var pair in data)
		{
			var key = pair.Key;
			var uid = (int)Convert.ChangeType(pair.Value, typeof(int));

			var prop = t.GetProperty(key);
			afterCreationDelegates.Add(() =>
			{
				prop.SetValue(o, uidToObjectLookup[uid], null);
			});
		}
	}

	void DeserializeFields(Dictionary<string, object> data, object o)
	{
		var t = o.GetType();

		foreach (var pair in data)
		{
			var key = pair.Key;

			var tv = t.GetProperty(key).PropertyType;
			if (tv.IsEnum)
			{
				t.GetProperty(key).SetValue(o, Enum.ToObject(tv, pair.Value));
			}
			else if (tv == typeof(int))
			{
				var prop = t.GetProperty(key);

				prop.SetValue(o, Convert.ChangeType(pair.Value, prop.PropertyType), null);
			}
			else if (tv == typeof(string))
			{
				t.GetProperty(key).SetValue(o, (string)pair.Value);
			}
			else if (tv == typeof(float))
			{
				t.GetProperty(key).SetValue(o, (float)((double)pair.Value));
			}
			else if (tv == typeof(bool))
			{
				t.GetProperty(key).SetValue(o, (bool)pair.Value);
			}
			else if (tv == typeof(Vector2))
			{
				var vvv = (object[])pair.Value;

				t.GetProperty(key).SetValue(o, new Vector2((float)((double)vvv[0]), (float)((double)vvv[1])));
			}
			else if (tv == typeof(Vector3))
			{
				var vvv = (object[])pair.Value;
				t.GetProperty(key).SetValue(o, new Vector3((float)((double)vvv[0]), (float)((double)vvv[1]), (float)((double)vvv[2])));
			}
			else if (tv == typeof(RectOffset))
			{
				var vvv = (object[])pair.Value;
				int left = (int)Convert.ChangeType(vvv[0], typeof(int));
				int bottom = (int)Convert.ChangeType(vvv[1], typeof(int));
				int top = (int)Convert.ChangeType(vvv[2], typeof(int));
				int right = (int)Convert.ChangeType(vvv[3], typeof(int));
				t.GetProperty(key).SetValue(o, new RectOffset(left, right, top, bottom));
			}
			else if (tv == typeof(Color))
			{
				var vvv = (object[])pair.Value;
				t.GetProperty(key).SetValue(o, new Color((float)((double)vvv[0]), (float)((double)vvv[1]), (float)((double)vvv[2]), (float)((double)vvv[3])));
			}
			else if (typeof(Sprite).IsAssignableFrom(tv))
			{
				var vvv = (string)pair.Value;

				for (int i = 0; i < textureNames.Length; i++)
				{
					if (textureNames[i] == vvv)
					{
						t.GetProperty(key).SetValue(o, textures[i]);
					}
				}
			}
			else if (typeof(Font).IsAssignableFrom(tv))
			{
				var vvv = (string)pair.Value;

				for (int i = 0; i < fontNames.Length; i++)
				{
					if (fontNames[i] == vvv)
					{
						t.GetProperty(key).SetValue(o, fonts[i]);
					}
				}
			}
			else if (tv == typeof(UnityEngine.UI.ColorBlock))
			{
				var vvv = (object[])pair.Value;
				var index = 0;
				var block = new UnityEngine.UI.ColorBlock();
				block.normalColor = new Color(
					(float)((double)vvv[index * 4 + 0]),
					(float)((double)vvv[index * 4 + 1]),
					(float)((double)vvv[index * 4 + 2]),
					(float)((double)vvv[index * 4 + 3]));
				index++;
				block.highlightedColor = new Color(
					(float)((double)vvv[index * 4 + 0]),
					(float)((double)vvv[index * 4 + 1]),
					(float)((double)vvv[index * 4 + 2]),
					(float)((double)vvv[index * 4 + 3]));
				index++;
				block.pressedColor = new Color(
					(float)((double)vvv[index * 4 + 0]),
					(float)((double)vvv[index * 4 + 1]),
					(float)((double)vvv[index * 4 + 2]),
					(float)((double)vvv[index * 4 + 3]));
				index++;
				block.selectedColor = new Color(
					(float)((double)vvv[index * 4 + 0]),
					(float)((double)vvv[index * 4 + 1]),
					(float)((double)vvv[index * 4 + 2]),
					(float)((double)vvv[index * 4 + 3]));
				index++;
				block.disabledColor = new Color(
					(float)((double)vvv[index * 4 + 0]),
					(float)((double)vvv[index * 4 + 1]),
					(float)((double)vvv[index * 4 + 2]),
					(float)((double)vvv[index * 4 + 3]));
				index++;
				block.colorMultiplier = (float)((double)vvv[index * 4 + 0]);
				block.fadeDuration = (float)((double)vvv[index * 4 + 1]);

				t.GetProperty(key).SetValue(o, block);
			}
			else
			{
				throw new Exception($"Error {key} is unknown type {tv}");
			}

		}
	}

	Dictionary<string, object> SerializeComponent(Component c)
	{
		var thisUid = uid++;
		objectToUidLookup.Add(c, thisUid);
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("name", c.GetType().ToString().Split('.').Last());
		data.Add("uid", thisUid);
		data.Add("type", c.GetType().ToString());
		var k = "" + c.GetType();

		if (types.ContainsKey(k))
		{
			Dictionary<string, object> fieldsData = new Dictionary<string, object>();
			SerializeFields(fieldsData, c, types[k].props);
			data.Add("fields", fieldsData);

			Dictionary<string, object> linksData = new Dictionary<string, object>();
			if (types[k].links != null)
			{
				SerializeLinks(linksData, c, types[k].links);
			}
			data.Add("links", linksData);
		}
		else if (typeof(MonoBehaviour).IsAssignableFrom(c.GetType()))
		{
			Debug.Log(c);
		}

		return data;
	}

	private Dictionary<string, object> SerializeInner(GameObject gameObject)
	{
		var thisUid = uid++;

		Dictionary<string, object> data = new Dictionary<string, object>();

		data.Add("name", gameObject.name);
		data.Add("uid", thisUid);
		objectToUidLookup.Add(gameObject, thisUid);

		var comps = gameObject.GetComponents(typeof(Component)).
			Where(v => v.GetType() != typeof(ExportImport)).
			Select(v => SerializeComponent(v)).ToArray();

		data.Add("components", comps);
		var children = Enumerable.Range(0, gameObject.transform.childCount).Select(v => {
			return SerializeInner(gameObject.transform.GetChild(v).gameObject);
		}).ToArray();
		data.Add("children", children);

		return data;
	}

	public Dictionary<string, object> Serialize(GameObject gameObject)
	{
		uid = 0;
		uidToObjectLookup.Clear();
		afterCreationDelegates.Clear();
		var v = SerializeInner(gameObject);

		foreach (var vv in afterCreationDelegates)
		{
			vv.Invoke();
		}

		return v;
	}

	static Dictionary<string, ClassProperties> types = new Dictionary<string, ClassProperties> {
		{
			"UnityEngine.Canvas",
			new ClassProperties(
				typeof(Canvas),
				new String[]
				{
					"renderMode",
					"sortingOrder",
				}
			)
		},
		{
			"UnityEngine.RectTransform",
			new ClassProperties(
				typeof(RectTransform),
			new String[]
			{
				"anchorMin",
				"anchorMax",
				"pivot",
				"offsetMin",
				"offsetMax",

			}
			)
		},
		{
			"UnityEngine.UI.HorizontalLayoutGroup",
			new ClassProperties(
				typeof(UnityEngine.UI.HorizontalLayoutGroup),
				new String[]
				{
					"childAlignment",
					"childForceExpandHeight",
					"childForceExpandWidth",
					"childControlHeight",
					"childControlWidth",
					"childScaleHeight",
					"childScaleWidth",
					"spacing",
					"padding",
				})
		},
		{
			"UnityEngine.UI.VerticalLayoutGroup",
			new ClassProperties(
				typeof(UnityEngine.UI.VerticalLayoutGroup),
				new String[]
				{
					"childAlignment",
					"childForceExpandHeight",
					"childForceExpandWidth",
					"childControlHeight",
					"childControlWidth",
					"childScaleHeight",
					"childScaleWidth",
					"spacing",
					"padding",
				}
			)
		},
		{
			"UnityEngine.UI.ScrollRect",
			new ClassProperties(
				typeof(UnityEngine.UI.ScrollRect),
				new String[]
				{
					"movementType",
					"horizontal",
					"vertical",
					"elasticity",
					"inertia",
					"decelerationRate",
					"scrollSensitivity",
					"horizontalScrollbarSpacing",
					"horizontalScrollbarVisibility",
					"verticalScrollbarSpacing",
					"verticalScrollbarVisibility",
				},
				new string[] {
					"content",
					"viewport",
					"horizontalScrollbar",
					"verticalScrollbar",
				})
		},
		{
			"UnityEngine.UI.Image",
			new ClassProperties(
				typeof(UnityEngine.UI.Image),
				new String[]
				{
					"color",
					"sprite",

					"type",
					"useSpriteMesh",
					"preserveAspect",
					"fillCenter",
					//"pixelsPerUnitMultiplier",
					"fillMethod",
					"fillAmount",
					"fillClockwise",
					"fillOrigin",
				})
		},
		{
			"UnityEngine.UI.Mask",
			new ClassProperties(
				typeof(UnityEngine.UI.Mask),
				new String[]
				{
				})
		},
		{
			"UnityEngine.UI.GraphicRaycaster",
			new ClassProperties(
				typeof(UnityEngine.UI.GraphicRaycaster),
				new String[]
				{
				})
		},
		{
			"UnityEngine.UI.Scrollbar",
			new ClassProperties(
				typeof(UnityEngine.UI.Scrollbar),
				new String[]
				{
					"interactable",
					"transition",
					"colors",
					"direction",
					"value",
					"size",
					"numberOfSteps",
				},
				new String[] {
					"targetGraphic",
					"handleRect",
				})
		},
		{
			"UnityEngine.UI.ContentSizeFitter",
			new ClassProperties(
				typeof(UnityEngine.UI.ContentSizeFitter),
				new String[]
				{
					"horizontalFit",
					"verticalFit",
				})
		},
		{
			"UnityEngine.UI.Button",
			new ClassProperties(
				typeof(UnityEngine.UI.Button),
				new String[]
				{
					"interactable",
					"transition",
					"colors",
				})
		},
		{
			"UnityEngine.UI.Text",
			new ClassProperties(
				typeof(UnityEngine.UI.Text),
				new String[]
				{
					"text",
					"font",
					"fontSize",
					"fontStyle",
					"lineSpacing",
					"supportRichText",
					"alignment",
					"horizontalOverflow",
					"verticalOverflow",
					"resizeTextForBestFit",
					"color",
					"raycastTarget",
					"maskable",
				})
		},

	};




	private GameObject DeserializeInner(Dictionary<string, System.Object> data, Transform parent)
	{
		UnityEngine.UI.Image a;

		//a.mainTexture.name;
		//a.targetGraphic
		//	a.handleRect


		GameObject go = new GameObject();
		go.name = (string)data["name"];
		uidToObjectLookup.Add((int)((long)data["uid"]), go);
		go.transform.parent = parent;
		var c = data["components"];
		foreach (var vv in ((object[])data["components"]))
		{

			var v = (Dictionary<string, object>)vv;
			var key = (string)v["type"];
			if (types.ContainsKey(key))
			{
				var t = types[(string)v["type"]].classType;
				Component co = null;
				if (t == typeof(RectTransform))
				{
					co = go.GetComponent<RectTransform>();
					if (co == null)
					{
						co = go.AddComponent<RectTransform>();
					}
				}
				else
				{
					co = go.AddComponent(t);
				}
				uidToObjectLookup.Add((int)((long)v["uid"]), co);

				DeserializeFields((Dictionary<string, object>)v["fields"], co);
				DeserializeLinks((Dictionary<string, object>)v["links"], co);


			}
			else
			{
				Type t = FullGetType(key);
				//var con = t.GetConstructor(Type.EmptyTypes);
				/*if(con != null)
				{
					var instance = con.Invoke(new object[0]);
				}*/
				if (t != null)
				{
					go.AddComponent(t);

					Debug.Log("No type for " + key);
				}
				else
				{
					throw new Exception("No class found for type:" + key);
				}
			}
		}

		foreach (var vv in ((object[])data["children"]))
		{
			var v = (Dictionary<string, object>)vv;
			var g = DeserializeInner(v, go.transform);
		}

		return go;

	}

	public static Type FullGetType(string typeName)
	{
		var type = Type.GetType(typeName);
		if (type != null) return type;
		foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
		{
			type = a.GetType(typeName);
			if (type != null)
				return type;
		}
		return null;
	}

	public GameObject Deserialize(Dictionary<string, System.Object> data, Transform parent)
	{
		afterCreationDelegates.Clear();
		var v = DeserializeInner(data, parent);
		foreach (var vv in afterCreationDelegates)
		{
			vv.Invoke();
		}
		return v;
	}

	// Update is called once per frame
	void Update()
	{

	}


	public Dictionary<string, System.Object> JsonDeserialize(string toDeserialize)
	{
		var v = JsonConvert.DeserializeObject(toDeserialize);
		return (Dictionary<string, System.Object>)fixJson(v);
	}

	public string JsonSerialize<T>(T toSerialize)
	{
		return JsonConvert.SerializeObject(toSerialize);
	}
	public object fixJson(object v)
	{
		if (v.GetType() == typeof(JObject))
		{
			var vv = (JObject)v;
			var vvv = new Dictionary<String, object>();
			foreach (KeyValuePair<string, JToken> keyValuePair in vv)
			{
				vvv.Add(keyValuePair.Key, fixJson(keyValuePair.Value));
			}
			return vvv;
		}
		else if (v.GetType() == typeof(JArray))
		{
			var vv = (JArray)v;
			var vvv = new object[vv.Count];
			for (int i = 0; i < vv.Count; i++)
			{
				vvv[i] = fixJson(vv[i]);
			}
			return vvv;
		}
		else if (v.GetType() == typeof(JValue))
		{
			var vv = (JValue)v;
			//Debug.Log(vv.Value.GetType());
			return vv.Value;
		}

		Debug.Log(v.GetType());
		return null;
	}
}
