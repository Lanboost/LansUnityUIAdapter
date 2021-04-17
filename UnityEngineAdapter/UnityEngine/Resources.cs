#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
	public sealed class Resources
	{
		public Resources() { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     Returns a list of all objects of Type type.
		//
		// Parameters:
		//   type:

		public static Object[] FindObjectsOfTypeAll(Type type) { throw new System.NotImplementedException(); }
		public static T[] FindObjectsOfTypeAll<T>() where T : Object { throw new System.NotImplementedException(); }

		public static Object GetBuiltinResource([NotNull] Type type, string path) { throw new System.NotImplementedException(); }
		public static T GetBuiltinResource<T>(string path) where T : Object { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Loads an asset stored at path in a Resources folder.
		//
		// Parameters:
		//   path:
		//     Path to the target resource to load. When using an empty string (i.e., ""), the
		//     function loads the entire contents of the Resources folder.
		//
		//   systemTypeInstance:
		//     Type filter for objects returned.
		//
		// Returns:
		//     The requested asset returned as an Object.
		public static Object Load(string path) { throw new System.NotImplementedException(); }
		public static T Load<T>(string path) where T : Object { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Loads an asset stored at path in a Resources folder.
		//
		// Parameters:
		//   path:
		//     Path to the target resource to load. When using an empty string (i.e., ""), the
		//     function loads the entire contents of the Resources folder.
		//
		//   systemTypeInstance:
		//     Type filter for objects returned.
		//
		// Returns:
		//     The requested asset returned as an Object.
		public static Object Load(string path, [NotNull] Type systemTypeInstance) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Loads all assets in a folder or file at path in a Resources folder.
		//
		// Parameters:
		//   path:
		//     Pathname of the target folder. When using the empty string (i.e., ""), the function
		//     will load the entire contents of the Resources folder.
		public static Object[] LoadAll(string path) { throw new System.NotImplementedException(); }
		public static T[] LoadAll<T>(string path) where T : Object { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Loads all assets in a folder or file at path in a Resources folder.
		//
		// Parameters:
		//   path:
		//     Pathname of the target folder. When using the empty string (i.e., ""), the function
		//     will load the entire contents of the Resources folder.
		//
		//   systemTypeInstance:
		//     Type filter for objects returned.

		public static Object[] LoadAll([NotNull] string path, [NotNull] Type systemTypeInstance) { throw new System.NotImplementedException(); }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use AssetDatabase.LoadAssetAtPath<T>() instead (UnityUpgradable) -> * [UnityEditor] UnityEditor.AssetDatabase.LoadAssetAtPath<T>(*)", true)]
		public static T LoadAssetAtPath<T>(string assetPath) where T : Object { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a resource at an asset path (Editor Only).
		//
		// Parameters:
		//   assetPath:
		//     Pathname of the target asset.
		//
		//   type:
		//     Type filter for objects returned.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use AssetDatabase.LoadAssetAtPath instead (UnityUpgradable) -> * [UnityEditor] UnityEditor.AssetDatabase.LoadAssetAtPath(*)", true)]
		//[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		public static Object LoadAssetAtPath(string assetPath, Type type) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Asynchronously loads an asset stored at path in a Resources folder.
		//
		// Parameters:
		//   path:
		//     Pathname of the target folder. When using the empty string (i.e., ""), the function
		//     will load the entire contents of the Resources folder.
		//public static ResourceRequest LoadAsync(string path) { throw new System.NotImplementedException(); }
		//public static ResourceRequest LoadAsync<T>(string path) where T : Object { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Asynchronously loads an asset stored at path in a Resources folder.
		//
		// Parameters:
		//   path:
		//     Pathname of the target folder. When using the empty string (i.e., ""), the function
		//     will load the entire contents of the Resources folder.
		//
		//   systemTypeInstance:
		//     Type filter for objects returned.
		//
		//   type:
		//public static ResourceRequest LoadAsync(string path, Type type) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Unloads assetToUnload from memory.
		//
		// Parameters:
		//   assetToUnload:
		//[FreeFunction("Scripting::UnloadAssetFromScripting")]
		public static void UnloadAsset(Object assetToUnload) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Unloads assets that are not used.
		//
		// Returns:
		//     Object on which you can yield to wait until the operation completes.
		//[FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
		public static AsyncOperation UnloadUnusedAssets() { throw new System.NotImplementedException(); }
	}
}