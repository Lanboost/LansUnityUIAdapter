#region Assembly UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIModule.dll
#endregion

namespace UnityEngine
{
	public interface ICanvasRaycastFilter
	{
		//
		// Summary:
		//     Given a point and a camera is the raycast valid.
		//
		// Parameters:
		//   sp:
		//     Screen position.
		//
		//   eventCamera:
		//     Raycast camera.
		//
		// Returns:
		//     Valid.
		bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
	}
}