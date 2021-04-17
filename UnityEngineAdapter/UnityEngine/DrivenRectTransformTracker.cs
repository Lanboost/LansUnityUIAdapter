#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
	public struct DrivenRectTransformTracker
	{
		//
		// Summary:
		//     Resume recording undo of driven RectTransforms.
		//public static void StartRecordingUndo();
		//
		// Summary:
		//     Stop recording undo actions from driven RectTransforms.
		//public static void StopRecordingUndo();
		//
		// Summary:
		//     Add a RectTransform to be driven.
		//
		// Parameters:
		//   driver:
		//     The object to drive properties.
		//
		//   rectTransform:
		//     The RectTransform to be driven.
		//
		//   drivenProperties:
		//     The properties to be driven.
		public void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties) {
			
		}
		[Obsolete("revertValues parameter is ignored. Please use Clear() instead.")]
		public void Clear(bool revertValues) {
		}
		//
		// Summary:
		//     Clear the list of RectTransforms being driven.
		public void Clear() {
			//Do nothing?
		}
	}
}