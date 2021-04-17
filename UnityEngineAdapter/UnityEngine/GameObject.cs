
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security;

namespace UnityEngine
{
	public sealed class GameObject : Object
	{
		bool _active = true;
		List<Component> components = new List<Component>();

		internal IEnumerable<MonoBehaviour> GetEnabledMonoBehaviours()
		{
			foreach(var c in components.ToArray())
			{
				if(c is MonoBehaviour)
				{
					var m = (MonoBehaviour)c;
					if (m.enabled)
					{
						yield return (MonoBehaviour)c;
					}
				}
			}
		}

		internal IEnumerable<Component> GetComponents()
		{
			foreach (var c in components)
			{
				yield return c;
			}
		}

		public IEnumerable<GameObject> GetActiveChildren()
		{
			for (int i = 0; i < this.transform.childCount; i++)
			{
				var go = this.transform.GetChild(i).gameObject;
				if(go.activeSelf)
				{
					yield return go;
				}
			}
		}


		public GameObject() : this("GameObject", new Type[] { })
		{ }
		//
		// Summary:
		//     Creates a new game object, named name.
		//
		// Parameters:
		//   name:
		//     The name that the GameObject is created with.
		//
		//   components:
		//     A list of Components to add to the GameObject on creation.
		public GameObject(string name):this(name, new Type[] { })
		{
		}
		//
		// Summary:
		//     Creates a new game object, named name.
		//
		// Parameters:
		//   name:
		//     The name that the GameObject is created with.
		//
		//   components:
		//     A list of Components to add to the GameObject on creation.
		public GameObject(string name, params Type[] components) {
			this.name = name;
			var rectTransform = new RectTransform();
			rectTransform._gameObject = this;
			rectTransform.Init(new Rect(0,0,100, 100));
			
			transform = rectTransform;
			this.components.Add(rectTransform);
		}

		//
		// Summary:
		//     The ParticleSystem attached to this GameObject (Read Only). (Null if there is
		//     none attached).
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property particleSystem has been deprecated. Use GetComponent<ParticleSystem>() instead. (UnityUpgradable)", true)]
		public Component particleSystem { get; }
		//
		// Summary:
		//     The Transform attached to this GameObject.
		public Transform transform { get; }
		//
		// Summary:
		//     The layer the game object is in.
		public int layer { get; set; }
		[Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
		public bool active { get => activeSelf; set => SetActive(value); }
		//
		// Summary:
		//     The local active state of this GameObject. (Read Only)
		public bool activeSelf { get => _active; }
		//
		// Summary:
		//     Defines whether the GameObject is active in the Scene.
		public bool activeInHierarchy {
			get
			{
				if(transform.parent == null)
				{
					return activeSelf;
				}
				else
				{
					return activeSelf && transform.parent.gameObject.activeInHierarchy;
				}
			}
		}
		//
		// Summary:
		//     Gets and sets the GameObject's StaticEditorFlags.
		public bool isStatic { get; set; }
		//
		// Summary:
		//     The tag of this game object.
		public string tag { get; set; }
		//
		// Summary:
		//     Scene that the GameObject is part of.
		//public Scene scene { get; }
		//
		// Summary:
		//     Scene culling mask Unity uses to determine which scene to render the GameObject
		//     in.
		public ulong sceneCullingMask { get; }
		public GameObject gameObject { get => this; }
		public Component rigidbody2D { get; }
		public Component camera { get; }
		public Component light { get; }
		public Component animation { get; }
		public Component constantForce { get; }
		public Component renderer { get; }
		public Component audio { get; }
		public Component networkView { get; }
		public Component collider { get; }
		public Component collider2D { get; }
		public Component rigidbody { get; }

		public Component hingeJoint { get; }

		//public static GameObject CreatePrimitive(PrimitiveType type) { throw new System.NotImplementedException(); }

		public static GameObject Find(string name) { throw new System.NotImplementedException(); }

		public static GameObject[] FindGameObjectsWithTag(string tag) { throw new System.NotImplementedException(); }

		public static GameObject FindGameObjectWithTag(string tag) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns one active GameObject tagged tag. Returns null if no GameObject was found.
		//
		// Parameters:
		//   tag:
		//     The tag to search for.
		public static GameObject FindWithTag(string tag) { throw new System.NotImplementedException(); }
		public T AddComponent<T>() where T : Component {
			return (T) AddComponent(typeof(T));
		}

		public Component AddComponent(string className) { throw new System.NotImplementedException(); }
		

		public Component AddComponent(Type componentType) {

			foreach(var comp in this.components)
			{
				if(comp.GetType() == componentType)
				{
					throw new Exception("Cant instantiate duplicate component on gameobject");
				}
			}


			var c = (Component) Activator.CreateInstance(componentType, true);
			this.components.Add(c);
			c._gameObject = this;
			c.name = "" + c.GetType();
			if(c is Canvas)
			{
				var rectTransform = this.GetComponent<RectTransform>();
				//rectTransform._parentSize = new Vector2(1000, 500);
				//rectTransform._size = new Vector2(1000, 500);
				//rectTransform.ForceUpdateRectTransforms();
				rectTransform.UpdateParent(new Rect(0,0,944, 471));
			}

			return c;
		}
		//
		// Parameters:
		//   methodName:
		//
		//   options:
		//public void BroadcastMessage(string methodName, SendMessageOptions options) { throw new System.NotImplementedException(); }

		//public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { throw new System.NotImplementedException(); }

		public void BroadcastMessage(string methodName, object parameter) { throw new System.NotImplementedException(); }
		public void BroadcastMessage(string methodName) { throw new System.NotImplementedException(); }
		public bool CompareTag(string tag) { throw new System.NotImplementedException(); }
		[SecuritySafeCritical]
		public T GetComponent<T>() {
			foreach(var v in this.components)
			{
				if(v is T)
				{
					return (T) (object) v;
				}
			}
			return default(T);
		}
		
		public Component GetComponent(Type type) {
			foreach (var v in this.components)
			{
				if (v.GetType().IsSubclassOf(type))
				{
					return v;
				}
			}
			return null;
		}
		//
		// Summary:
		//     Returns the component with name type if the game object has one attached, null
		//     if it doesn't.
		//
		// Parameters:
		//   type:
		//     The type of Component to retrieve.
		public Component GetComponent(string type) { throw new System.NotImplementedException(); }
		

		public Component GetComponentInChildren(Type type) { throw new System.NotImplementedException(); }
		

		public Component GetComponentInChildren(Type type, bool includeInactive) { throw new System.NotImplementedException(); }



		public T GetComponentInChildren<T>(bool includeInactive) {
			var self = GetComponent<T>();
			if(self == null)
			{
				for(int i=0; i<transform.childCount; i++)
				{
					var c = transform.GetChild(i);
					var cs = c.GetComponentInChildren<T>(includeInactive);
					if(cs != null)
					{
						return cs;
					}
				}
			}
			else
			{
				return self;
			}

			return default(T);
		}
		
		public T GetComponentInChildren<T>() { return GetComponentInChildren<T>(false); }
		public T GetComponentInParent<T>() { throw new System.NotImplementedException(); }
		
		public Component GetComponentInParent(Type type) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns all components of Type type in the GameObject.
		//
		// Parameters:
		//   type:
		//     The type of component to retrieve.
		public Component[] GetComponents(Type type) {
			var temp = new List<Component>();
			GetComponents(type, temp);
			return temp.ToArray();
		}
		public T[] GetComponents<T>() {
			var temp = new List<T>();
			foreach (var v in this.components)
			{
				if (v is T)
				{
					temp.Add((T)(object)v);
				}
			}
			return temp.ToArray();
		}
		public void GetComponents(Type type, List<Component> results) {
			foreach (var v in this.components)
			{
				if (type.IsAssignableFrom(v.GetType()))
				{
					results.Add(v);
				}
			}
		}
		public void GetComponents<T>(List<T> results) {
			foreach (var v in this.components)
			{
				if (v is T)
				{
					results.Add((T)(object)v);
				}
			}
		}
		public T[] GetComponentsInChildren<T>() { return (T[])(object)GetComponentsInChildren(typeof(T), false); }
		//
		// Summary:
		//     Returns all components of Type type in the GameObject or any of its children.
		//
		// Parameters:
		//   type:
		//     The type of Component to retrieve.
		//
		//   includeInactive:
		//     Should Components on inactive GameObjects be included in the found set?
		[ExcludeFromDocs]
		public Component[] GetComponentsInChildren(Type type) { return GetComponentsInChildren(type, false); }
		//
		// Summary:
		//     Returns all components of Type type in the GameObject or any of its children.
		//
		// Parameters:
		//   type:
		//     The type of Component to retrieve.
		//
		//   includeInactive:
		//     Should Components on inactive GameObjects be included in the found set?
		public Component[] GetComponentsInChildren(Type type, bool includeInactive) {
			List<Component> components = new List<Component>();
			GetComponentsInChildren(type, includeInactive, components);

			return components.ToArray();
		}

		public T[] GetComponentsInChildren<T>(bool includeInactive) {
			return (T[])(object)GetComponentsInChildren(typeof(T), includeInactive);
		}

		public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) {
			GetComponentsInChildren(typeof(T), includeInactive, results);
		}

		public void GetComponentsInChildren<T>(Type type, bool includeInactive, List<T> results)
		{
			var self = GetComponent(type);
			if (self != null)
			{
				components.Add(self);
			}

			for (int i = 0; i < transform.childCount; i++)
			{
				var c = transform.GetChild(i);
				c.gameObject.GetComponentsInChildren(type, includeInactive, components);
			}
		}

		public void GetComponentsInChildren<T>(List<T> results) {
			GetComponentsInChildren(typeof(T), false, results);
		}
		public T[] GetComponentsInParent<T>(bool includeInactive) { throw new System.NotImplementedException(); }
		[ExcludeFromDocs]
		public Component[] GetComponentsInParent(Type type) { throw new System.NotImplementedException(); }

		void  InnerGetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			if (this.transform.parent != null)
			{
				this.transform.parent.gameObject.InnerGetComponentsInParent<T>(includeInactive, results);
			}
			this.GetComponents<T>(results);
		}

		public void GetComponentsInParent<T>(bool includeInactive, List<T> results) {
			//TODO
			this.transform.parent.gameObject.InnerGetComponentsInParent<T>(includeInactive, results);
		}
		public T[] GetComponentsInParent<T>() {
			List<T> temp = new List<T>();
			GetComponentsInParent<T>(false, temp);
			return temp.ToArray();
		}
		//
		// Summary:
		//     Returns all components of Type type in the GameObject or any of its parents.
		//
		// Parameters:
		//   type:
		//     The type of Component to retrieve.
		//
		//   includeInactive:
		//     Should inactive Components be included in the found set?
		public Component[] GetComponentsInParent(Type type, bool includeInactive) { throw new System.NotImplementedException(); }
		public void PlayAnimation(Object animation) { throw new System.NotImplementedException(); }
		public void SampleAnimation(Object clip, float time) { throw new System.NotImplementedException(); }
		//
		// Parameters:
		//   methodName:
		//
		//   options:
		//public void SendMessage(string methodName, SendMessageOptions options) { throw new System.NotImplementedException(); }

		//public void SendMessage(string methodName, [Internal.DefaultValue("null")] object value, [Internal.DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options) { throw new System.NotImplementedException(); }

		//public void SendMessage(string methodName, object value) { throw new System.NotImplementedException(); }

		//public void SendMessage(string methodName) { throw new System.NotImplementedException(); }

		//public void SendMessageUpwards(string methodName, [Internal.DefaultValue("null")] object value, [Internal.DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options) { throw new System.NotImplementedException(); }
		//
		// Parameters:
		//   methodName:
		//
		//   options:
		//public void SendMessageUpwards(string methodName, SendMessageOptions options) { throw new System.NotImplementedException(); }

		public void SendMessageUpwards(string methodName) { throw new System.NotImplementedException(); }

		public void SendMessageUpwards(string methodName, object value) { throw new System.NotImplementedException(); }

		public void SetActive(bool value) {
			_active = value;
			//TODO
		}
		public void SetActiveRecursively(bool state) { throw new System.NotImplementedException(); }
		public void StopAnimation() { throw new System.NotImplementedException(); }
		public bool TryGetComponent(Type type, out Component component) { throw new System.NotImplementedException(); }
		public bool TryGetComponent<T>(out T component) { throw new System.NotImplementedException(); }
	}
}