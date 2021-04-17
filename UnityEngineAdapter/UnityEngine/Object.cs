#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Security;

namespace UnityEngine
{

	public class Object
	{
		public Object() {
			this.name = "Object";
		}

		//
		// Summary:
		//     Should the object be hidden, saved with the Scene or modifiable by the user?
		public HideFlags hideFlags { get; set; }
		//
		// Summary:
		//     The name of the object.
		public string name { get; set; }

		//
		// Summary:
		//     Removes a GameObject, component or asset.
		//
		// Parameters:
		//   obj:
		//     The object to destroy.
		//
		//   t:
		//     The optional amount of time to delay before destroying the object.
		[ExcludeFromDocs]
		public static void Destroy(Object obj) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Removes a GameObject, component or asset.
		//
		// Parameters:
		//   obj:
		//     The object to destroy.
		//
		//   t:
		//     The optional amount of time to delay before destroying the object.
		[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = true, ThrowsException = true)]
		public static void Destroy(Object obj, [DefaultValue("0.0F")] float t) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Destroys the object obj immediately. You are strongly recommended to use Destroy
		//     instead.
		//
		// Parameters:
		//   obj:
		//     Object to be destroyed.
		//
		//   allowDestroyingAssets:
		//     Set to true to allow assets to be destroyed.
		[ExcludeFromDocs]
		public static void DestroyImmediate(Object obj) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Destroys the object obj immediately. You are strongly recommended to use Destroy
		//     instead.
		//
		// Parameters:
		//   obj:
		//     Object to be destroyed.
		//
		//   allowDestroyingAssets:
		//     Set to true to allow assets to be destroyed.
		[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = true, ThrowsException = true)]
		public static void DestroyImmediate(Object obj, [DefaultValue("false")] bool allowDestroyingAssets) { throw new System.NotImplementedException(); }
		[Obsolete("use Object.Destroy instead.")]
		public static void DestroyObject(Object obj, [DefaultValue("0.0F")] float t) { throw new System.NotImplementedException(); }
		[ExcludeFromDocs]
		[Obsolete("use Object.Destroy instead.")]
		public static void DestroyObject(Object obj) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Do not destroy the target Object when loading a new Scene.
		//
		// Parameters:
		//   target:
		//     An Object not destroyed on Scene change.
		[FreeFunction("GetSceneManager().DontDestroyOnLoad")]
		public static void DontDestroyOnLoad(Object target) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the first active loaded object of Type type.
		//
		// Parameters:
		//   type:
		//     The type of object to find.
		//
		// Returns:
		//     This returns the Object that matches the specified type. It returns null if no
		//     Object matches the type.
		//[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public static Object FindObjectOfType(Type type) { throw new System.NotImplementedException(); }
		public static T FindObjectOfType<T>() where T : Object { throw new System.NotImplementedException(); }
		public static T[] FindObjectsOfType<T>() where T : Object { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a list of all active loaded objects of Type type.
		//
		// Parameters:
		//   type:
		//     The type of object to find.
		//
		//   includeInactive:
		//     If true, components attached to inactive GameObjects are also included.
		//
		// Returns:
		//     The array of objects found matching the type specified.
		[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
		//[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		public static Object[] FindObjectsOfType(Type type) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a list of all active and inactive loaded objects of Type type.
		//
		// Parameters:
		//   type:
		//     The type of object to find.
		//
		// Returns:
		//     The array of objects found matching the type specified.
		[Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
		public static Object[] FindObjectsOfTypeAll(Type type) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a list of all active and inactive loaded objects of Type type, including
		//     assets.
		//
		// Parameters:
		//   type:
		//     The type of object or asset to find.
		//
		// Returns:
		//     The array of objects and assets found matching the type specified.
		[FreeFunction("UnityEngineObjectBindings::FindObjectsOfTypeIncludingAssets")]
		[Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
		public static Object[] FindObjectsOfTypeIncludingAssets(Type type) { throw new System.NotImplementedException(); }
		[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
		[Obsolete("warning use Object.FindObjectsOfType instead.")]
		public static Object[] FindSceneObjectsOfType(Type type) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Clones the object original and returns the clone.
		//
		// Parameters:
		//   original:
		//     An existing object that you want to make a copy of.
		//
		//   position:
		//     Position for the new object.
		//
		//   rotation:
		//     Orientation of the new object.
		//
		//   parent:
		//     Parent that will be assigned to the new object.
		//
		//   instantiateInWorldSpace:
		//     When you assign a parent Object, pass true to position the new object directly
		//     in world space. Pass false to set the Object’s position relative to its new parent..
		//
		// Returns:
		//     The instantiated clone.
		//[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Clones the object original and returns the clone.
		//
		// Parameters:
		//   original:
		//     An existing object that you want to make a copy of.
		//
		//   position:
		//     Position for the new object.
		//
		//   rotation:
		//     Orientation of the new object.
		//
		//   parent:
		//     Parent that will be assigned to the new object.
		//
		//   instantiateInWorldSpace:
		//     When you assign a parent Object, pass true to position the new object directly
		//     in world space. Pass false to set the Object’s position relative to its new parent..
		//
		// Returns:
		//     The instantiated clone.
		//[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Transform parent) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Clones the object original and returns the clone.
		//
		// Parameters:
		//   original:
		//     An existing object that you want to make a copy of.
		//
		//   position:
		//     Position for the new object.
		//
		//   rotation:
		//     Orientation of the new object.
		//
		//   parent:
		//     Parent that will be assigned to the new object.
		//
		//   instantiateInWorldSpace:
		//     When you assign a parent Object, pass true to position the new object directly
		//     in world space. Pass false to set the Object’s position relative to its new parent..
		//
		// Returns:
		//     The instantiated clone.
		//[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Clones the object original and returns the clone.
		//
		// Parameters:
		//   original:
		//     An existing object that you want to make a copy of.
		//
		//   position:
		//     Position for the new object.
		//
		//   rotation:
		//     Orientation of the new object.
		//
		//   parent:
		//     Parent that will be assigned to the new object.
		//
		//   instantiateInWorldSpace:
		//     When you assign a parent Object, pass true to position the new object directly
		//     in world space. Pass false to set the Object’s position relative to its new parent..
		//
		// Returns:
		//     The instantiated clone.
		//[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { throw new System.NotImplementedException(); }
		public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object { throw new System.NotImplementedException(); }
		public static T Instantiate<T>(T original, Transform parent) where T : Object { throw new System.NotImplementedException(); }
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object { throw new System.NotImplementedException(); }
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object { throw new System.NotImplementedException(); }
		public static T Instantiate<T>(T original) where T : Object { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Clones the object original and returns the clone.
		//
		// Parameters:
		//   original:
		//     An existing object that you want to make a copy of.
		//
		//   position:
		//     Position for the new object.
		//
		//   rotation:
		//     Orientation of the new object.
		//
		//   parent:
		//     Parent that will be assigned to the new object.
		//
		//   instantiateInWorldSpace:
		//     When you assign a parent Object, pass true to position the new object directly
		//     in world space. Pass false to set the Object’s position relative to its new parent..
		//
		// Returns:
		//     The instantiated clone.
		//[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { throw new System.NotImplementedException(); }
		//public override bool Equals(object other) { throw new System.NotImplementedException(); }
		//public override int GetHashCode() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the instance id of the object.
		[SecuritySafeCritical]
		public int GetInstanceID() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the name of the object.
		//
		// Returns:
		//     The name returned by ToString.
		//public override string ToString() { throw new System.NotImplementedException(); }

		/*public static bool operator ==(Object x, Object y) { throw new System.NotImplementedException(); }
		public static bool operator !=(Object x, Object y) {
			return x != y;
		}*/

		public static implicit operator bool(Object exists) { return exists != null; }
	}
}