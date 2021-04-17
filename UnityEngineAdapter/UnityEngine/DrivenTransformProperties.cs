#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
	//
	// Summary:
	//     An enumeration of transform properties that can be driven on a RectTransform
	//     by an object.
	[Flags]
	public enum DrivenTransformProperties
	{
		//
		// Summary:
		//     Selects all driven properties.
		All = -1,
		//
		// Summary:
		//     Deselects all driven properties.
		None = 0,
		//
		// Summary:
		//     Selects driven property RectTransform.anchoredPosition.x.
		AnchoredPositionX = 2,
		//
		// Summary:
		//     Selects driven property RectTransform.anchoredPosition.y.
		AnchoredPositionY = 4,
		//
		// Summary:
		//     Selects driven property RectTransform.anchoredPosition.
		AnchoredPosition = 6,
		//
		// Summary:
		//     Selects driven property RectTransform.anchoredPosition3D.z.
		AnchoredPositionZ = 8,
		//
		// Summary:
		//     Selects driven property RectTransform.anchoredPosition3D.
		AnchoredPosition3D = 14,
		//
		// Summary:
		//     Selects driven property Transform.localRotation.
		Rotation = 16,
		//
		// Summary:
		//     Selects driven property Transform.localScale.x.
		ScaleX = 32,
		//
		// Summary:
		//     Selects driven property Transform.localScale.y.
		ScaleY = 64,
		//
		// Summary:
		//     Selects driven property Transform.localScale.z.
		ScaleZ = 128,
		//
		// Summary:
		//     Selects driven property combining ScaleX, ScaleY && ScaleZ.
		Scale = 224,
		//
		// Summary:
		//     Selects driven property RectTransform.anchorMin.x.
		AnchorMinX = 256,
		//
		// Summary:
		//     Selects driven property RectTransform.anchorMin.y.
		AnchorMinY = 512,
		//
		// Summary:
		//     Selects driven property combining AnchorMinX and AnchorMinY.
		AnchorMin = 768,
		//
		// Summary:
		//     Selects driven property RectTransform.anchorMax.x.
		AnchorMaxX = 1024,
		//
		// Summary:
		//     Selects driven property RectTransform.anchorMax.y.
		AnchorMaxY = 2048,
		//
		// Summary:
		//     Selects driven property combining AnchorMaxX and AnchorMaxY.
		AnchorMax = 3072,
		//
		// Summary:
		//     Selects driven property combining AnchorMinX, AnchorMinY, AnchorMaxX and AnchorMaxY.
		Anchors = 3840,
		//
		// Summary:
		//     Selects driven property RectTransform.sizeDelta.x.
		SizeDeltaX = 4096,
		//
		// Summary:
		//     Selects driven property RectTransform.sizeDelta.y.
		SizeDeltaY = 8192,
		//
		// Summary:
		//     Selects driven property combining SizeDeltaX and SizeDeltaY.
		SizeDelta = 12288,
		//
		// Summary:
		//     Selects driven property RectTransform.pivot.x.
		PivotX = 16384,
		//
		// Summary:
		//     Selects driven property RectTransform.pivot.y.
		PivotY = 32768,
		//
		// Summary:
		//     Selects driven property combining PivotX and PivotY.
		Pivot = 49152
	}
}