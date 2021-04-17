using System;

namespace UnityEngine
{
	public struct Rect
	{
		Vector2 _position;
		Vector2 _size;
		//
		// Parameters:
		//   source:
		public Rect(Rect source):this(source.position, source.size) {

		}
		//
		// Summary:
		//     Creates a rectangle given a size and position.
		//
		// Parameters:
		//   position:
		//     The position of the minimum corner of the rect.
		//
		//   size:
		//     The width and height of the rect.
		public Rect(Vector2 position, Vector2 size) {
			this._position = position;
			this._size = size;
		}
		//
		// Summary:
		//     Creates a new rectangle.
		//
		// Parameters:
		//   x:
		//     The X value the rect is measured from.
		//
		//   y:
		//     The Y value the rect is measured from.
		//
		//   width:
		//     The width of the rectangle.
		//
		//   height:
		//     The height of the rectangle.
		public Rect(float x, float y, float width, float height):this(new Vector2(x, y), new Vector2(width, height)) { }

		//
		// Summary:
		//     Shorthand for writing new Rect(0,0,0,0).
		public static Rect zero { get => new Rect(0, 0, 0, 0); }
		[Obsolete("use xMin")]
		public float left { get => _position.x; }
		//
		// Summary:
		//     The maximum Y coordinate of the rectangle.
		public float yMax { get => _position.y + _size.y; set => _size.y = value - _position.y; }
		//
		// Summary:
		//     The maximum X coordinate of the rectangle.
		public float xMax { get => _position.x+_size.x; set => _size.x = value- _position.x; }
		//
		// Summary:
		//     The minimum Y coordinate of the rectangle.
		public float yMin { get => _position.y; set => _position.y = value; }
		//
		// Summary:
		//     The minimum X coordinate of the rectangle.
		public float xMin { get => _position.x; set => _position.x = value; }
		//
		// Summary:
		//     The X coordinate of the rectangle.
		public float x { get => _position.x; set => _position.x = value; }
		//
		// Summary:
		//     The height of the rectangle, measured from the Y position.
		public float height { get => _size.y; set => _size.y = value; }
		//
		// Summary:
		//     The width of the rectangle, measured from the X position.
		public float width { get => _size.x; set => _size.x = value; }
		//
		// Summary:
		//     The position of the maximum corner of the rectangle.
		public Vector2 max { get => _position+_size; set => _size = value- _position; }
		//
		// Summary:
		//     The position of the minimum corner of the rectangle.
		public Vector2 min { get => _position; set => _position = value; }
		//
		// Summary:
		//     The position of the center of the rectangle.
		public Vector2 center { get => _position+_size/2; set=> _position = value- _size / 2; }
		//
		// Summary:
		//     The X and Y position of the rectangle.
		public Vector2 position { get => _position; set => _position = value; }
		//
		// Summary:
		//     The Y coordinate of the rectangle.
		public float y { get => _position.y; set => _position.y = value; }
		[Obsolete("use xMax")]
		public float right { get => _position.x+_size.x; }
		//
		// Summary:
		//     The width and height of the rectangle.
		public Vector2 size { get => _size; set => _size = value; }
		[Obsolete("use yMax")]
		public float bottom { get => _position.y; }
		[Obsolete("use yMin")]
		public float top { get => _position.y + _size.y; }

		//
		// Summary:
		//     Creates a rectangle from min/max coordinate values.
		//
		// Parameters:
		//   xmin:
		//     The minimum X coordinate.
		//
		//   ymin:
		//     The minimum Y coordinate.
		//
		//   xmax:
		//     The maximum X coordinate.
		//
		//   ymax:
		//     The maximum Y coordinate.
		//
		// Returns:
		//     A rectangle matching the specified coordinates.
		public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a point inside a rectangle, given normalized coordinates.
		//
		// Parameters:
		//   rectangle:
		//     Rectangle to get a point inside.
		//
		//   normalizedRectCoordinates:
		//     Normalized coordinates to get a point for.
		public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the normalized coordinates cooresponding the the point.
		//
		// Parameters:
		//   rectangle:
		//     Rectangle to get normalized coordinates inside.
		//
		//   point:
		//     A point inside the rectangle to get normalized coordinates for.
		public static Vector2 PointToNormalized(Rect rectangle, Vector2 point) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true if the x and y components of point is a point inside this rectangle.
		//     If allowInverse is present and true, the width and height of the Rect are allowed
		//     to take negative values (ie, the min value is greater than the max), and the
		//     test will still work.
		//
		// Parameters:
		//   point:
		//     Point to test.
		//
		//   allowInverse:
		//     Does the test allow the Rect's width and height to be negative?
		//
		// Returns:
		//     True if the point lies within the specified rectangle.
		public bool Contains(Vector3 point, bool allowInverse) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true if the x and y components of point is a point inside this rectangle.
		//     If allowInverse is present and true, the width and height of the Rect are allowed
		//     to take negative values (ie, the min value is greater than the max), and the
		//     test will still work.
		//
		// Parameters:
		//   point:
		//     Point to test.
		//
		//   allowInverse:
		//     Does the test allow the Rect's width and height to be negative?
		//
		// Returns:
		//     True if the point lies within the specified rectangle.
		public bool Contains(Vector3 point) {
			return this.position.x <= point.x && point.x < this.position.x + this.size.x &&
				 this.position.y <= point.y && point.y < this.position.y + this.size.y;
 		}
		//
		// Summary:
		//     Returns true if the x and y components of point is a point inside this rectangle.
		//     If allowInverse is present and true, the width and height of the Rect are allowed
		//     to take negative values (ie, the min value is greater than the max), and the
		//     test will still work.
		//
		// Parameters:
		//   point:
		//     Point to test.
		//
		//   allowInverse:
		//     Does the test allow the Rect's width and height to be negative?
		//
		// Returns:
		//     True if the point lies within the specified rectangle.
		public bool Contains(Vector2 point) { throw new System.NotImplementedException(); }
		public bool Equals(Rect other) { throw new System.NotImplementedException(); }
		public override bool Equals(object other) { throw new System.NotImplementedException(); }
		public override int GetHashCode() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true if the other rectangle overlaps this one. If allowInverse is present
		//     and true, the widths and heights of the Rects are allowed to take negative values
		//     (ie, the min value is greater than the max), and the test will still work.
		//
		// Parameters:
		//   other:
		//     Other rectangle to test overlapping with.
		//
		//   allowInverse:
		//     Does the test allow the widths and heights of the Rects to be negative?
		public bool Overlaps(Rect other, bool allowInverse) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns true if the other rectangle overlaps this one. If allowInverse is present
		//     and true, the widths and heights of the Rects are allowed to take negative values
		//     (ie, the min value is greater than the max), and the test will still work.
		//
		// Parameters:
		//   other:
		//     Other rectangle to test overlapping with.
		//
		//   allowInverse:
		//     Does the test allow the widths and heights of the Rects to be negative?
		public bool Overlaps(Rect other) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Set components of an existing Rect.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   width:
		//
		//   height:
		public void Set(float x, float y, float width, float height) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a nicely formatted string for this Rect.
		//
		// Parameters:
		//   format:
		//
		// Summary:
		//     Returns a nicely formatted string for this Rect.
		//
		// Parameters:
		//   format:

		public static bool operator ==(Rect lhs, Rect rhs) {
			return lhs.x == rhs.x && lhs.y == rhs.y && lhs.width == rhs.width && lhs.height == rhs.height;
		}
		public static bool operator !=(Rect lhs, Rect rhs) {
			return lhs.x != rhs.x || lhs.y != rhs.y || lhs.width != rhs.width || lhs.height != rhs.height;
		}
	}
}