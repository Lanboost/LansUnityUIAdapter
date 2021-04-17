using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityEngine
{
	public struct Vector3
	{
		public float x;
		public float y;
		public float z;

		public float this[int index]
		{
			get
			{
				if (index == 0)
				{
					return x;
				}
				else if (index == 1)
				{
					return y;
				}
				else
				{
					return z;
				}
			}
			set
			{
				if (index == 0)
				{
					x = value;
				}
				else if (index == 1)
				{
					y = value;
				}
				else
				{
					z = value;
				}
			}
		}

		public float sqrMagnitude { get => x * x + y * y; }

		public Vector3(float x, float y):this(x, y,0) { }
		public Vector3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static Vector3 right { get => new Vector3(1, 0, 0); }
		public static Vector3 left { get => new Vector3(-1, 0, 0); }
		public static Vector3 down { get => new Vector3(0, -1, 0); }
		public static Vector3 up { get => new Vector3(0, 1, 0); }
		public static Vector3 one { get => new Vector3(1, 1, 0); }
		public static Vector3 zero { get => new Vector3(0, 0, 0); }
		public static Vector3 back { get => new Vector3(0, 0, -1); }
		public static Vector3 forward { get => new Vector3(0, 0, 1); }
		public static Vector3 positiveInfinity { get => new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity); }
		public static Vector3 negativeInfinity { get => new Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity); }
		

		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
		}
		public static Vector3 operator -(Vector3 a)
		{
			return new Vector3(-a.x, -a.y, -a.z);
		}
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x - b.x, a.y - b.y, a.z-b.z);
		}
		public static Vector3 operator *(float d, Vector3 a)
		{
			return a * d;
		}
		public static Vector3 operator *(Vector3 a, float d)
		{
			return new Vector3(a.x * d, a.y * d, a.z*d);
		}
		public static Vector3 operator *(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x * b.x, a.y * b.y, a.z*b.z);
		}
		public static Vector3 operator /(Vector3 a, float d)
		{
			return new Vector3(a.x / d, a.y / d, a.z/d);
		}
		public static Vector3 operator /(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x / b.x, a.y / b.y, a.z/b.z);
		}
		public static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			return lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z;
		}
		public static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			return lhs.x != rhs.x || lhs.y != rhs.y || lhs.z != rhs.z;
		}

		public static Vector3 Lerp(Vector3 a, Vector3 b, float t) {
			return new Vector3(
				Mathf.Lerp(a.x, b.x, t),
				Mathf.Lerp(a.y, b.y, t),
				Mathf.Lerp(a.z, b.z, t)
			);
		}

		public static Vector3 Max(Vector3 a, Vector3 b)
		{
			return new Vector3(
				Mathf.Max(a.x, b.x),
				Mathf.Max(a.y, b.y),
				Mathf.Max(a.z, b.z)
			);
		}
		//
		// Summary:
		//     Returns a vector that is made from the smallest components of two vectors.
		//
		// Parameters:
		//   lhs:
		//
		//   rhs:
		public static Vector3 Min(Vector3 a, Vector3 b)
		{
			return new Vector3(
				Mathf.Min(a.x, b.x),
				Mathf.Min(a.y, b.y),
				Mathf.Min(a.z, b.z)
			);
		}
		public static float Dot(Vector3 a, Vector3 b)
		{
			return a.x * b.x + a.y * b.y + a.z * b.z;
		}
		public Vector3 normalized { get {
				var len = (float) Math.Sqrt(Dot(this, this));
				return new Vector3(this.x / len, this.y/len, this.z/len);
			}
		}

		public static float Distance(Vector3 a, Vector3 b)
		{
			return (float) Math.Sqrt((a - b).sqrMagnitude);
		}


		//public static implicit operator Vector3(Vector2 v) => new Vector3(v.x, v.y, 0);
		//public static implicit operator Vector2(Vector3 v) => new Vector2(v.x, v.y);

		public override string ToString()
		{
			return $"Vector3({x},{y},{z})";
		}
	}
}
