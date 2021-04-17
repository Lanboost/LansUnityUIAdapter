using System;
using System.Collections;
namespace UnityEngine
{

	public class MonoBehaviour : Behaviour
	{
		public MonoBehaviour() {
			
		}

		

		
		/*public virtual void Update() {}
		public virtual void LateUpdate() {}
		public virtual void FixedUpdate() {}
		public virtual void OnWillRenderObject() {}

		void Awake()
		{ }

		void OnEnable()
		{ }

		void Start()
		{ }

		void OnDisable()
		{ }

		void OnDestroy()
		{ }

		/// <summary>
		/// Returns true if the GameObject and the Component are active.
		/// </summary>
		bool IsActive()
		{
			return isActiveAndEnabled;
		}

		void OnRectTransformDimensionsChange()
		{ }

		void OnBeforeTransformParentChanged()
		{ }

		void OnTransformParentChanged()
		{ }

		void OnDidApplyAnimationProperties()
		{ }

		void OnCanvasGroupChanged()
		{ }

		/// <summary>
		/// Called when the state of the parent Canvas is changed.
		/// </summary>
		void OnCanvasHierarchyChanged()
		{ }*/

		//
		// Summary:
		//     Disabling this lets you skip the GUI layout phase.
		public bool useGUILayout { get; set; }
		//
		// Summary:
		//     Allow a specific instance of a MonoBehaviour to run in edit mode (only available
		//     in the editor).
		public bool runInEditMode { get; set; }

		//
		// Summary:
		//     Logs message to the Unity Console (identical to Debug.Log).
		//
		// Parameters:
		//   message:
		public static void print(object message) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Cancels all Invoke calls with name methodName on this behaviour.
		//
		// Parameters:
		//   methodName:
		public void CancelInvoke(string methodName) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Cancels all Invoke calls on this MonoBehaviour.
		public void CancelInvoke() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Invokes the method methodName in time seconds.
		//
		// Parameters:
		//   methodName:
		//
		//   time:
		public void Invoke(string methodName, float time) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Invokes the method methodName in time seconds, then repeatedly every repeatRate
		//     seconds.
		//
		// Parameters:
		//   methodName:
		//
		//   time:
		//
		//   repeatRate:
		public void InvokeRepeating(string methodName, float time, float repeatRate) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Is any invoke on methodName pending?
		//
		// Parameters:
		//   methodName:
		public bool IsInvoking(string methodName) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Is any invoke pending on this MonoBehaviour?
		public bool IsInvoking() {
			throw new System.NotImplementedException();
		}
		//
		// Summary:
		//     Starts a coroutine named methodName.
		//
		// Parameters:
		//   methodName:
		//
		//   value:
		[ExcludeFromDocs]
		public Coroutine StartCoroutine(string methodName) {
			throw new System.NotImplementedException();
		}
		//
		// Summary:
		//     Starts a Coroutine.
		//
		// Parameters:
		//   routine:
		public Coroutine StartCoroutine(IEnumerator routine) {
			return UnityEngineAdapter.CoroutineHandler.Instance().Add(routine);
		}
		//
		// Summary:
		//     Starts a coroutine named methodName.
		//
		// Parameters:
		//   methodName:
		//
		//   value:
		public Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value) { throw new System.NotImplementedException(); }
		[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", false)]
		public Coroutine StartCoroutine_Auto(IEnumerator routine) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Stops all coroutines running on this behaviour.
		public void StopAllCoroutines() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Stops the first coroutine named methodName, or the coroutine stored in routine
		//     running on this behaviour.
		//
		// Parameters:
		//   methodName:
		//     Name of coroutine.
		//
		//   routine:
		//     Name of the function in code, including coroutines.
		public void StopCoroutine(IEnumerator routine) {
			UnityEngineAdapter.CoroutineHandler.Instance().Remove(routine);
		}
		//
		// Summary:
		//     Stops the first coroutine named methodName, or the coroutine stored in routine
		//     running on this behaviour.
		//
		// Parameters:
		//   methodName:
		//     Name of coroutine.
		//
		//   routine:
		//     Name of the function in code, including coroutines.
		public void StopCoroutine(Coroutine routine) {
			UnityEngineAdapter.CoroutineHandler.Instance().Remove(routine.value);
		}
		//
		// Summary:
		//     Stops the first coroutine named methodName, or the coroutine stored in routine
		//     running on this behaviour.
		//
		// Parameters:
		//   methodName:
		//     Name of coroutine.
		//
		//   routine:
		//     Name of the function in code, including coroutines.
		public void StopCoroutine(string methodName) { throw new System.NotImplementedException(); }
	}
}