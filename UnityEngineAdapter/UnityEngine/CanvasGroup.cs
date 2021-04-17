#region Assembly UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIModule.dll
#endregion


namespace UnityEngine
{

	public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
	{
		public CanvasGroup() { throw new System.NotImplementedException(); }

		public float alpha { get; set; }
		public bool interactable { get; set; }
		//
		// Summary:
		//     Does this group block raycasting (allow collision).

		public bool blocksRaycasts { get; set; }
		//
		// Summary:
		//     Should the group ignore parent groups?

		public bool ignoreParentGroups { get; set; }

		//
		// Summary:
		//     Returns true if the Group allows raycasts.
		//
		// Parameters:
		//   sp:
		//
		//   eventCamera:
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { throw new System.NotImplementedException(); }
	}
}