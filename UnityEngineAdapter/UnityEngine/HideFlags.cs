#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
	//
	// Summary:
	//     Bit mask that controls object destruction, saving and visibility in inspectors.
	[Flags]
	public enum HideFlags
	{
		//
		// Summary:
		//     A normal, visible object. This is the default.
		None = 0,
		//
		// Summary:
		//     The object will not appear in the hierarchy.
		HideInHierarchy = 1,
		//
		// Summary:
		//     It is not possible to view it in the inspector.
		HideInInspector = 2,
		//
		// Summary:
		//     The object will not be saved to the Scene in the editor.
		DontSaveInEditor = 4,
		//
		// Summary:
		//     The object is not be editable in the inspector.
		NotEditable = 8,
		//
		// Summary:
		//     The object will not be saved when building a player.
		DontSaveInBuild = 16,
		//
		// Summary:
		//     The object will not be unloaded by Resources.UnloadUnusedAssets.
		DontUnloadUnusedAsset = 32,
		//
		// Summary:
		//     The object will not be saved to the Scene. It will not be destroyed when a new
		//     Scene is loaded. It is a shortcut for HideFlags.DontSaveInBuild | HideFlags.DontSaveInEditor
		//     | HideFlags.DontUnloadUnusedAsset.
		DontSave = 52,
		//
		// Summary:
		//     The GameObject is not shown in the Hierarchy, not saved to to Scenes, and not
		//     unloaded by Resources.UnloadUnusedAssets.
		HideAndDontSave = 61
	}
}