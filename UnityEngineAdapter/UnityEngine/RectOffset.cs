
namespace UnityEngine
{

	public class RectOffset
	{
		//
		// Summary:
		//     Creates a new rectangle with offsets.
		//
		// Parameters:
		//   left:
		//
		//   right:
		//
		//   top:
		//
		//   bottom:
		public RectOffset() {

		}
		//
		// Summary:
		//     Creates a new rectangle with offsets.
		//
		// Parameters:
		//   left:
		//
		//   right:
		//
		//   top:
		//
		//   bottom:
		public RectOffset(int left, int right, int top, int bottom) {
			this.left = left;
			this.right = right;
			this.top = top;
			this.bottom = bottom;
		}

		~RectOffset() {  }
		
		public int left { get; set; }
		public int right { get; set; }
		public int top { get; set; }
		public int bottom { get; set; }
		//
		// Summary:
		//     Shortcut for left + right. (Read Only)
		public int horizontal { get => left+right; }
		//
		// Summary:
		//     Shortcut for top + bottom. (Read Only)
		public int vertical { get => top+bottom; }

		//
		// Summary:
		//     Add the border offsets to a rect.
		//
		// Parameters:
		//   rect:
		public Rect Add(Rect rect) {
			float x1 = rect.xMin - left;
			float y1 = rect.yMin - bottom;
			float x2 = rect.xMax + right;
			float y2 = rect.yMax + top;

			return new Rect(x1, y1, x2 - x1, y2 - y1);
		}
		//
		// Summary:
		//     Remove the border offsets from a rect.
		//
		// Parameters:
		//   rect:
		public Rect Remove(Rect rect) {
			float x1 = rect.xMin + left;
			float y1 = rect.yMin + bottom;
			float x2 = rect.xMax - right;
			float y2 = rect.yMax - top;

			return new Rect(x1, y1, x2-x1, y2-y1);
		}
	}
}