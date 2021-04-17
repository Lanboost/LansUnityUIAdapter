namespace UnityEngine
{

	public sealed class RectTransformUtility
	{
		public static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child) { throw new System.NotImplementedException(); }
		public static Bounds CalculateRelativeRectTransformBounds(Transform trans) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Flips the horizontal and vertical axes of the RectTransform size and alignment,
		//     and optionally its children as well.
		//
		// Parameters:
		//   rect:
		//     The RectTransform to flip.
		//
		//   keepPositioning:
		//     Flips around the pivot if true. Flips within the parent rect if false.
		//
		//   recursive:
		//     Flip the children as well?
		public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Flips the alignment of the RectTransform along the horizontal or vertical axis,
		//     and optionally its children as well.
		//
		// Parameters:
		//   rect:
		//     The RectTransform to flip.
		//
		//   keepPositioning:
		//     Flips around the pivot if true. Flips within the parent rect if false.
		//
		//   recursive:
		//     Flip the children as well?
		//
		//   axis:
		//     The axis to flip along. 0 is horizontal and 1 is vertical.
		public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Convert a given point in screen space into a pixel correct point.
		//
		// Parameters:
		//   point:
		//
		//   elementTransform:
		//
		//   canvas:
		//
		// Returns:
		//     Pixel adjusted point.
		public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Given a rect transform, return the corner points in pixel accurate coordinates.
		//
		// Parameters:
		//   rectTransform:
		//
		//   canvas:
		//
		// Returns:
		//     Pixel adjusted rect.
		public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { throw new System.NotImplementedException(); }
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Does the RectTransform contain the screen point as seen from the given camera?
		//
		// Parameters:
		//   rect:
		//     The RectTransform to test with.
		//
		//   screenPoint:
		//     The screen point to test.
		//
		//   cam:
		//     The camera from which the test is performed from. (Optional)
		//
		// Returns:
		//     True if the point is inside the rectangle.
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) {
			//TODO
			UnityEngine.Vector3[] corners = new UnityEngine.Vector3[4];
			rect.GetWorldCorners(corners);

			return
				(int)corners[0].x <= screenPoint.x &&
				screenPoint.x < (int)corners[2].x &&
				(int)corners[0].y <= screenPoint.y &&
				screenPoint.y < (int)corners[2].y;
		}
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { throw new System.NotImplementedException(); }
		public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) {
			Vector3[] worldCorners = new Vector3[4];
			rect.GetWorldCorners(worldCorners);
			localPoint.x = screenPoint.x - worldCorners[0].x;
			localPoint.y = screenPoint.y - worldCorners[0].y;
			return true;
		}
		public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { throw new System.NotImplementedException(); }
		public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { throw new System.NotImplementedException(); }
		public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { throw new System.NotImplementedException(); }
	}
}