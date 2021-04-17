#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
	public struct Bounds //: IEquatable<Bounds>
	{
		Vector3 _min;
		Vector3 _max;


		//
		// Summary:
		//     Creates a new Bounds.
		//
		// Parameters:
		//   center:
		//     The location of the origin of the Bounds.
		//
		//   size:
		//     The dimensions of the Bounds.
		public Bounds(Vector3 center, Vector3 size)
		{
			//this.center = center;
			//this.size = size;
			//this.extents = size / 2;
			this._min = Vector3.Min(center - size/2, center + size / 2);
			this._max = Vector3.Max(center - size / 2, center + size / 2);
		}
		
		//
		// Summary:
		//     The extents of the Bounding Box. This is always half of the size of the Bounds.
		public Vector3 extents { get => size/2; set => size = value*2; }
		//
		// Summary:
		//     The total size of the box. This is always twice as large as the extents.
		public Vector3 size { get => (this._max - this._min);
			set
			{
				var diff = (value-size)/2;
				this._max += diff;
				this._min -= diff;
			}
		}
		//
		// Summary:
		//     The center of the bounding box.
		public Vector3 center
		{
			get => this._min + extents;
			set
			{
				var diff = value - center;
				this._min += diff;
				this._max += diff;
			}
		}
		//
		// Summary:
		//     The minimal point of the box. This is always equal to center-extents.
		public Vector3 min { get => _min; set => _min = value; }
		//
		// Summary:
		//     The maximal point of the box. This is always equal to center+extents.
		public Vector3 max { get => _max; set => _max = value; }
		/*
		//
		// Summary:
		//     The closest point on the bounding box.
		//
		// Parameters:
		//   point:
		//     Arbitrary point.
		//
		// Returns:
		//     The point on the bounding box or inside the bounding box.
		[FreeFunction("BoundsScripting::ClosestPoint", HasExplicitThis = true, IsThreadSafe = true)]
		public Vector3 ClosestPoint(Vector3 point);
		//
		// Summary:
		//     Is point contained in the bounding box?
		//
		// Parameters:
		//   point:
		[NativeMethod("IsInside", IsThreadSafe = true)]
		public bool Contains(Vector3 point);
		//
		// Summary:
		//     Grows the Bounds to include the point.
		//
		// Parameters:
		//   point:
		*/
		public void Encapsulate(Vector3 point)
		{
			this._min = Vector3.Min(this._min, point);
			this._max = Vector3.Max(this._max, point);
			

		}
		//
		// Summary:
		//     Grow the bounds to encapsulate the bounds.
		//
		// Parameters:
		//   bounds:
		public void Encapsulate(Bounds bounds)
		{
			throw new NotImplementedException();
		}
		/*
		public override bool Equals(object other);
		public bool Equals(Bounds other);
		//
		// Summary:
		//     Expand the bounds by increasing its size by amount along each side.
		//
		// Parameters:
		//   amount:
		public void Expand(float amount);
		//
		// Summary:
		//     Expand the bounds by increasing its size by amount along each side.
		//
		// Parameters:
		//   amount:
		public void Expand(Vector3 amount);
		public override int GetHashCode();
		//
		// Summary:
		//     Does ray intersect this bounding box?
		//
		// Parameters:
		//   ray:
		public bool IntersectRay(Ray ray);
		public bool IntersectRay(Ray ray, out float distance);
		//
		// Summary:
		//     Does another bounding box intersect with this bounding box?
		//
		// Parameters:
		//   bounds:
		public bool Intersects(Bounds bounds);
		//
		// Summary:
		//     Sets the bounds to the min and max value of the box.
		//
		// Parameters:
		//   min:
		//
		//   max:
		public void SetMinMax(Vector3 min, Vector3 max);
		//
		// Summary:
		//     The smallest squared distance between the point and this bounding box.
		//
		// Parameters:
		//   point:
		[FreeFunction("BoundsScripting::SqrDistance", HasExplicitThis = true, IsThreadSafe = true)]
		public float SqrDistance(Vector3 point);
		//
		// Summary:
		//     Returns a nicely formatted string for the bounds.
		//
		// Parameters:
		//   format:
		public string ToString(string format);
		//
		// Summary:
		//     Returns a nicely formatted string for the bounds.
		//
		// Parameters:
		//   format:
		public override string ToString();
		*/

		public static bool operator ==(Bounds lhs, Bounds rhs)
		{
			return lhs.min == rhs.min && lhs.max == rhs.max;
		}
		public static bool operator !=(Bounds lhs, Bounds rhs)
		{
			return lhs.min != rhs.min || lhs.max != rhs.max;
		}

	}
}