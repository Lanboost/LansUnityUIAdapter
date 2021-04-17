using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security;

namespace UnityEngine
{
	public class Component : Object
	{
		internal GameObject _gameObject;

		

		public Component() { }
		
		public Component particleSystem { get; }
		//
		// Summary:
		//     The Transform attached to this GameObject.
		public Transform transform { get => _gameObject.transform; }
		//
		// Summary:
		//     The game object this component is attached to. A component is always attached
		//     to a game object.
		public GameObject gameObject { get => _gameObject; }
		//
		// Summary:
		//     The tag of this game object.
		public string tag { get; set; }

		public Component rigidbody { get; }
		public Component hingeJoint { get; }
		public Component camera { get; }
		public Component rigidbody2D { get; }
		//
		// Summary:
		//     The Animation attached to this GameObject. (Null if there is none attached).
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property animation has been deprecated. Use GetComponent<Animation>() instead. (UnityUpgradable)", true)]
		public Component animation { get; }
		//
		// Summary:
		//     The ConstantForce attached to this GameObject. (Null if there is none attached).
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property constantForce has been deprecated. Use GetComponent<ConstantForce>() instead. (UnityUpgradable)", true)]
		public Component constantForce { get; }
		//
		// Summary:
		//     The Renderer attached to this GameObject. (Null if there is none attached).
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property renderer has been deprecated. Use GetComponent<Renderer>() instead. (UnityUpgradable)", true)]
		public Component renderer { get; }
		//
		// Summary:
		//     The AudioSource attached to this GameObject. (Null if there is none attached).
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property audio has been deprecated. Use GetComponent<AudioSource>() instead. (UnityUpgradable)", true)]
		public Component audio { get; }
		//
		// Summary:
		//     The NetworkView attached to this GameObject (Read Only). (null if there is none
		//     attached).
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property networkView has been deprecated. Use GetComponent<NetworkView>() instead. (UnityUpgradable)", true)]
		public Component networkView { get; }
		//
		// Summary:
		//     The Collider attached to this GameObject. (Null if there is none attached).
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property collider has been deprecated. Use GetComponent<Collider>() instead. (UnityUpgradable)", true)]
		public Component collider { get; }
		//
		// Summary:
		//     The Collider2D component attached to the object.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property collider2D has been deprecated. Use GetComponent<Collider2D>() instead. (UnityUpgradable)", true)]
		public Component collider2D { get; }
		//
		// Summary:
		//     The Light attached to this GameObject. (Null if there is none attached).
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Property light has been deprecated. Use GetComponent<Light>() instead. (UnityUpgradable)", true)]
		public Component light { get; }

		//
		// Summary:
		//     Calls the method named methodName on every MonoBehaviour in this game object
		//     or any of its children.
		//
		// Parameters:
		//   methodName:
		//     Name of the method to call.
		//
		//   parameter:
		//     Optional parameter to pass to the method (can be any value).
		//
		//   options:
		//     Should an error be raised if the method does not exist for a given target object?
		//public void BroadcastMessage(string methodName, SendMessageOptions options) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Calls the method named methodName on every MonoBehaviour in this game object
		//     or any of its children.
		//
		// Parameters:
		//   methodName:
		//     Name of the method to call.
		//
		//   parameter:
		//     Optional parameter to pass to the method (can be any value).
		//
		//   options:
		//     Should an error be raised if the method does not exist for a given target object?
		//[ExcludeFromDocs]
		//public void BroadcastMessage(string methodName) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Calls the method named methodName on every MonoBehaviour in this game object
		//     or any of its children.
		//
		// Parameters:
		//   methodName:
		//     Name of the method to call.
		//
		//   parameter:
		//     Optional parameter to pass to the method (can be any value).
		//
		//   options:
		//     Should an error be raised if the method does not exist for a given target object?
		//[ExcludeFromDocs]
		//public void BroadcastMessage(string methodName, object parameter) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Calls the method named methodName on every MonoBehaviour in this game object
		//     or any of its children.
		//
		// Parameters:
		//   methodName:
		//     Name of the method to call.
		//
		//   parameter:
		//     Optional parameter to pass to the method (can be any value).
		//
		//   options:
		//     Should an error be raised if the method does not exist for a given target object?
		//[FreeFunction("BroadcastMessage", HasExplicitThis = true)]
		//public void BroadcastMessage(string methodName, [Internal.DefaultValue("null")] object parameter, [Internal.DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Is this game object tagged with tag ?
		//
		// Parameters:
		//   tag:
		//     The tag to compare.
		//public bool CompareTag(string tag) { throw new System.NotImplementedException(); }

		public Component GetComponent(Type type) { return gameObject.GetComponent(type); }
		[SecuritySafeCritical]
		public T GetComponent<T>() { return gameObject.GetComponent<T>(); }

		public Component GetComponent(string type) { return gameObject.GetComponent(type); }
		public Component GetComponentInChildren(Type t, bool includeInactive) { return gameObject.GetComponentInChildren(t, includeInactive); }

		public Component GetComponentInChildren(Type t) { return gameObject.GetComponentInChildren(t); }
		public T GetComponentInChildren<T>(bool includeInactive) { return gameObject.GetComponentInChildren<T>(includeInactive); }
		[ExcludeFromDocs]
		public T GetComponentInChildren<T>() { return gameObject.GetComponentInChildren<T>(); }
		//
		// Summary:
		//     Returns the component of Type type in the GameObject or any of its parents.
		//
		// Parameters:
		//   t:
		//     The type of Component to retrieve.
		//
		// Returns:
		//     A component of the matching type, if found.
		//[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public Component GetComponentInParent(Type t) { return gameObject.GetComponentInParent(t); }
		public T GetComponentInParent<T>() { return gameObject.GetComponentInParent<T>(); }
		//
		// Summary:
		//     Returns all components of Type type in the GameObject.
		//
		// Parameters:
		//   type:
		//     The type of Component to retrieve.
		public Component[] GetComponents(Type type) { return gameObject.GetComponents(type); }
		public void GetComponents(Type type, List<Component> results) { gameObject.GetComponents(type, results); }
		public void GetComponents<T>(List<T> results) { gameObject.GetComponents<T>(results); }
		public T[] GetComponents<T>() { return gameObject.GetComponents<T>(); }
		[ExcludeFromDocs]
		public Component[] GetComponentsInChildren(Type t) { return gameObject.GetComponentsInChildren(t); }
		public void GetComponentsInChildren<T>(List<T> results) { gameObject.GetComponentsInChildren<T>(results); }
		public T[] GetComponentsInChildren<T>() { return gameObject.GetComponentsInChildren<T>(); }
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) { gameObject.GetComponentsInChildren<T>(includeInactive, result); }
		public T[] GetComponentsInChildren<T>(bool includeInactive) { return gameObject.GetComponentsInChildren<T>(includeInactive); }
		//
		// Summary:
		//     Returns all components of Type type in the GameObject or any of its children.
		//
		// Parameters:
		//   t:
		//     The type of Component to retrieve.
		//
		//   includeInactive:
		//     Should Components on inactive GameObjects be included in the found set? includeInactive
		//     decides which children of the GameObject will be searched. The GameObject that
		//     you call GetComponentsInChildren on is always searched regardless.
		public Component[] GetComponentsInChildren(Type t, bool includeInactive) { return gameObject.GetComponentsInChildren(t,includeInactive); }
		public T[] GetComponentsInParent<T>(bool includeInactive) { return gameObject.GetComponentsInParent<T>(includeInactive); }
		[ExcludeFromDocs]
		public Component[] GetComponentsInParent(Type t) { return gameObject.GetComponentsInParent(t); }
		//
		// Summary:
		//     Returns all components of Type type in the GameObject or any of its parents.
		//
		// Parameters:
		//   t:
		//     The type of Component to retrieve.
		//
		//   includeInactive:
		//     Should inactive Components be included in the found set?
		public Component[] GetComponentsInParent(Type t, bool includeInactive) { return gameObject.GetComponentsInParent(t, includeInactive); }
		public T[] GetComponentsInParent<T>() { return gameObject.GetComponentsInParent<T>(); }
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { gameObject.GetComponentsInParent<T>(includeInactive, results); }
		//
		// Summary:
		//     Calls the method named methodName on every MonoBehaviour in this game object.
		//
		// Parameters:
		//   methodName:
		//     Name of the method to call.
		//
		//   value:
		//     Optional parameter for the method.
		//
		//   options:
		//     Should an error be raised if the target object doesn't implement the method for
		//     the message?
		[FreeFunction("SendMessage", HasExplicitThis = true)]
		//public void SendMessage(string methodName, object value, SendMessageOptions options) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Calls the method named methodName on every MonoBehaviour in this game object.
		//
		// Parameters:
		//   methodName:
		//     Name of the method to call.
		//
		//   value:
		//     Optional parameter for the method.
		//
		//   options:
		//     Should an error be raised if the target object doesn't implement the method for
		//     the message?
		public void SendMessage(string methodName) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Calls the method named methodName on every MonoBehaviour in this game object.
		//
		// Parameters:
		//   methodName:
		//     Name of the method to call.
		//
		//   value:
		//     Optional parameter for the method.
		//
		//   options:
		//     Should an error be raised if the target object doesn't implement the method for
		//     the message?
		public void SendMessage(string methodName, object value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Calls the method named methodName on every MonoBehaviour in this game object.
		//
		// Parameters:
		//   methodName:
		//     Name of the method to call.
		//
		//   value:
		//     Optional parameter for the method.
		//
		//   options:
		//     Should an error be raised if the target object doesn't implement the method for
		//     the message?
		//public void SendMessage(string methodName, SendMessageOptions options) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Calls the method named methodName on every MonoBehaviour in this game object
		//     and on every ancestor of the behaviour.
		//
		// Parameters:
		//   methodName:
		//     Name of method to call.
		//
		//   value:
		//     Optional parameter value for the method.
		//
		//   options:
		//     Should an error be raised if the method does not exist on the target object?
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName, object value) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Calls the method named methodName on every MonoBehaviour in this game object
		//     and on every ancestor of the behaviour.
		//
		// Parameters:
		//   methodName:
		//     Name of method to call.
		//
		//   value:
		//     Optional parameter value for the method.
		//
		//   options:
		//     Should an error be raised if the method does not exist on the target object?
		//public void SendMessageUpwards(string methodName, SendMessageOptions options) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Calls the method named methodName on every MonoBehaviour in this game object
		//     and on every ancestor of the behaviour.
		//
		// Parameters:
		//   methodName:
		//     Name of method to call.
		//
		//   value:
		//     Optional parameter value for the method.
		//
		//   options:
		//     Should an error be raised if the method does not exist on the target object?
		[ExcludeFromDocs]
		public void SendMessageUpwards(string methodName) { throw new System.NotImplementedException(); }
		
		//public void SendMessageUpwards(string methodName,object value,SendMessageOptions options) { throw new System.NotImplementedException(); }
		[SecuritySafeCritical]
		public bool TryGetComponent<T>(out T component) { throw new System.NotImplementedException(); }
		public bool TryGetComponent(Type type, out Component component) { throw new System.NotImplementedException(); }
	}
}