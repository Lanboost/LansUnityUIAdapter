using System;
using UnityEngine;

namespace UnityEngineAdapter
{
	public class UnityEngineMainHandler
	{

		long Millis()
		{
			long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
			return milliseconds;
		}

		public GameObject main = new GameObject();
		long startTime = 0;
		long lastFrame = 0;
		int _width = 10;
		int _height = 10;


		public UnityEngineMainHandler()
		{

		}

		public void Start()
		{
			startTime = Millis();
			lastFrame = startTime;

			// populate canvas render depth
			var currDepth = 1;
			RunOnGameObjectsComponents(main, delegate (Component m) {
				if (m is CanvasRenderer)
				{
					((CanvasRenderer)m).absoluteDepth = currDepth;
					currDepth++;
				}
			});
			RunOnGameObjects(main, delegate (MonoBehaviour m) {
				Helper.Call(m, "OnEnable");
			});
			RunOnGameObjects(main, delegate (MonoBehaviour m) {
				Helper.Call(m, "Awake");
			});
			RunOnGameObjects(main, delegate (MonoBehaviour m) {
				Helper.Call(m, "Start");
			});
		}

		public int ScreenWidth
		{
			get => _width;
			set
			{
				Screen.width = value;
				_width = value;
				var canvas = main.GetComponentInChildren<Canvas>();
				if (canvas != null)
				{
					var rect = canvas.gameObject.GetComponent<RectTransform>();
					rect._parentRect = new Rect(0, 0, _width, _height);
					rect._offsetMin = new UnityEngine.Vector2(0, 0);
					rect._offsetMax = new UnityEngine.Vector2(0, 0);
					rect._anchorMin = new UnityEngine.Vector2(0, 0);
					rect._anchorMax = new UnityEngine.Vector2(1, 1);
					rect.UpdateParent(rect._parentRect);
				}
			}
		}

		public int ScreenHeight
		{
			get => _height;
			set
			{
				Screen.height = value;
				_height = value;
				var canvas = main.GetComponentInChildren<Canvas>();
				if (canvas != null)
				{
					var rect = canvas.gameObject.GetComponent<RectTransform>();
					rect._parentRect = new Rect(0, 0, _width, _height);
					rect._offsetMin = new UnityEngine.Vector2(0, 0);
					rect._offsetMax = new UnityEngine.Vector2(0, 0);
					rect._anchorMin = new UnityEngine.Vector2(0, 0);
					rect._anchorMax = new UnityEngine.Vector2(1, 1);
					rect.UpdateParent(rect._parentRect);
				}
			}
		}


		void RunOnGameObjects(GameObject o, Action<MonoBehaviour> action)
		{
			foreach (var m in o.GetEnabledMonoBehaviours())
			{
				var no = o.name;
				var n = m.name;
				action(m);
			}

			foreach (var go in o.GetActiveChildren())
			{
				RunOnGameObjects(go, action);
			}
		}

		void RunOnGameObjectsComponents(GameObject o, Action<Component> action)
		{
			foreach (var m in o.GetComponents())
			{
				var no = o.name;
				var n = m.name;
				action(m);
			}

			foreach (var go in o.GetActiveChildren())
			{
				RunOnGameObjectsComponents(go, action);
			}
		}

		public void Update()
		{
			long now = Millis();
			long diff = now - lastFrame;
			lastFrame = now;
			//inputModule.Tick();
			CoroutineHandler.Instance().Tick();

			Time.fixedDeltaTime = 0.01f;
			Time.unscaledTime = (now - startTime) / 1000f;
			Time.unscaledDeltaTime = (diff) / 1000f;
			Time.deltaTime = (diff) / 1000f;
			Time.time = (now - startTime) / 1000f;

			

			Canvas.InvokeRender();


			RunOnGameObjects(main, delegate (MonoBehaviour m) {
				Helper.Call(m, "Update");
			});
			RunOnGameObjects(main, delegate (MonoBehaviour m) {
				Helper.Call(m, "FixedUpdate");
			});
			RunOnGameObjects(main, delegate (MonoBehaviour m) {
				Helper.Call(m, "LateUpdate");
			});
		}
	}
}
