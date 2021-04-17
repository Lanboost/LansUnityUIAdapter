using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityEngine
{
	public struct Vector4
	{
		public float x;
		public float y;
		public float z;
		public float w;

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
				else if (index == 2)
				{
					return z;
				}
				else
				{
					return w;
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
				else if (index == 2)
				{
					z = value;
				}
				else
				{
					w = value;
				}
			}
		}

		public float sqrMagnitude { get => x * x + y * y; }

		public Vector4(float x, float y):this(x, y,0,0) { }
		public Vector4(float x, float y, float z):this(x, y,z,0) { }
		public Vector4(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/*public static Vector3 right { get => new Vector3(1, 0, 0); }
		public static Vector3 left { get => new Vector3(-1, 0, 0); }
		public static Vector3 down { get => new Vector3(0, -1, 0); }
		public static Vector3 up { get => new Vector3(0, 1, 0); }
		public static Vector3 one { get => new Vector3(1, 1, 0); }*/
		public static Vector4 zero { get => new Vector4(0, 0, 0,0); }
		//public static Vector3 positiveInfinity { get => new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity); }
		//public static Vector3 negativeInfinity { get => new Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity); }

		/*
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
	}*/
		public static Vector4 operator /(Vector4 a, float d)
		{
			return new Vector4(a.x / d, a.y / d, a.z/d, a.w/d);
		}
		public static Vector4 operator /(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x / b.x, a.y / b.y, a.z/b.z, a.w/b.w);
		}
		/*
		public static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			return lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z;
		}
		public static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			return lhs.x != rhs.x || lhs.y != rhs.y || lhs.z != rhs.z;
		}
		*/
		//public static implicit operator Vector3(Vector2 v) => new Vector3(v.x, v.y, 0);
		//public static implicit operator Vector2(Vector3 v) => new Vector2(v.x, v.y);
	}
}
