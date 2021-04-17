using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityEngine
{
	public struct Vector2
	{
		public float x;
		public float y;

		public float this[int index]
		{
			get
			{
				if (index == 0)
				{
					return x;
				}
				else
				{
					return y;
				}
			}
			set
			{
				if (index == 0)
				{
					x = value;
				}
				else
				{
					y = value;
				}
			}
		}

		public float sqrMagnitude { get => x * x + y * y; }

		public Vector2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public static Vector2 right { get => new Vector2(1, 0); }
		public static Vector2 left { get => new Vector2(-1, 0); }
		public static Vector2 down { get => new Vector2(0, -1); }
		public static Vector2 up { get => new Vector2(0, 1); }
		public static Vector2 one { get => new Vector2(1, 1); }
		public static Vector2 zero { get => new Vector2(0, 0); }
		public static Vector2 positiveInfinity { get => new Vector2(float.PositiveInfinity, float.PositiveInfinity); }
		public static Vector2 negativeInfinity { get => new Vector2(float.NegativeInfinity, float.NegativeInfinity); }

		public static Vector2 Scale(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x * b.x, a.y * b.y);
		}


		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x + b.x, a.y + b.y);
		}
		public static Vector2 operator -(Vector2 a)
		{
			return new Vector2(-a.x, -a.y);
		}
		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x - b.x, a.y - b.y);
		}
		public static Vector2 operator *(float d, Vector2 a)
		{
			return a * d;
		}
		public static Vector2 operator *(Vector2 a, float d)
		{
			return new Vector2(a.x * d, a.y * d);
		}
		public static Vector2 operator *(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x * b.x, a.y * b.y);
		}
		public static Vector2 operator /(Vector2 a, float d)
		{
			return new Vector2(a.x / d, a.y / d);
		}
		public static Vector2 operator /(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x / b.x, a.y / b.y);
		}
		public static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			return lhs.x == rhs.x && lhs.y == rhs.y;
		}
		public static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			return lhs.x != rhs.x || lhs.y != rhs.y;
		}

		public static float Dot(Vector2 lhs, Vector2 rhs)
		{
			return lhs.x * rhs.x + lhs.y * rhs.y;
		}

		public static Vector2 Max(Vector2 a, Vector2 b)
		{
			return new Vector2(
				Mathf.Max(a.x, b.x),
				Mathf.Max(a.y, b.y)
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
		public static Vector2 Min(Vector2 a, Vector2 b)
		{
			return new Vector2(
				Mathf.Min(a.x, b.x),
				Mathf.Min(a.y, b.y)
			);
		}

		public static implicit operator Vector3(Vector2 v) => new Vector3(v.x, v.y, 0);
		public static implicit operator Vector2(Vector3 v) => new Vector2(v.x, v.y);


		public override string ToString()
		{
			return $"Vector2({x},{y})";
		}
	}
}
