#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;

namespace UnityEngine
{

	public struct Quaternion : IEquatable<Quaternion>
	{
		Vector3 _eulerAngles;

		public const float kEpsilon = 1E-06F;
		//
		// Summary:
		//     X component of the Quaternion. Don't modify this directly unless you know quaternions
		//     inside out.
		public float x;
		//
		// Summary:
		//     Y component of the Quaternion. Don't modify this directly unless you know quaternions
		//     inside out.
		public float y;
		//
		// Summary:
		//     Z component of the Quaternion. Don't modify this directly unless you know quaternions
		//     inside out.
		public float z;
		//
		// Summary:
		//     W component of the Quaternion. Do not directly modify quaternions.
		public float w;

		//
		// Summary:
		//     Constructs new Quaternion with given x,y,z,w components.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   z:
		//
		//   w:
		public Quaternion(float x, float y, float z, float w) {
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
			this._eulerAngles = new Vector3(0, 0, 0);

			// roll (x-axis rotation)
			double sinr_cosp = 2 * (w * x + y * z);
			double cosr_cosp = 1 - 2 * (x * x + y * y);
			this._eulerAngles[0] = (float) Math.Atan2(sinr_cosp, cosr_cosp);

			// pitch (y-axis rotation)
			double sinp = 2 * (w * y - z * x);
			if (Math.Abs(sinp) >= 1)
				this._eulerAngles[1] = (float)(Math.Sign(sinp)*(Math.PI / 2)); // use 90 degrees if out of range
			else
				this._eulerAngles[1] = (float) Math.Asin(sinp);

			// yaw (z-axis rotation)
			double siny_cosp = 2 * (w * z + x * y);
			double cosy_cosp = 1 - 2 * (y * y + z * z);
			this._eulerAngles[2] = (float)Math.Atan2(siny_cosp, cosy_cosp);
			

		}

		public float this[int index] { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }

		//
		// Summary:
		//     The identity rotation (Read Only).
		public static Quaternion identity {
			get
			{
				var q = new Quaternion(1,0,0,0);
				q.eulerAngles = new Vector3(0, 0, 0);
				return q;
			}
		}
		//
		// Summary:
		//     Returns or sets the euler angle representation of the rotation.
		public Vector3 eulerAngles {
			get => _eulerAngles;
			set
			{
				_eulerAngles = value;
				// Abbreviations for the various angular functions
				double cy = Math.Cos(_eulerAngles[0] * 0.5);
				double sy = Math.Sin(_eulerAngles[0] * 0.5);
				double cp = Math.Cos(_eulerAngles[1] * 0.5);
				double sp = Math.Sin(_eulerAngles[1] * 0.5);
				double cr = Math.Cos(_eulerAngles[2] * 0.5);
				double sr = Math.Sin(_eulerAngles[2] * 0.5);
				
				this.w = (float) (cr * cp * cy + sr * sp * sy);
				this.x = (float)(sr * cp * cy - cr * sp * sy);
				this.y = (float)(cr * sp * cy + sr * cp * sy);
				this.z = (float)(cr * cp * sy - sr * sp * cy);
			}
		}
		//
		// Summary:
		//     Returns this quaternion with a magnitude of 1 (Read Only).
		public Quaternion normalized { get { throw new System.NotImplementedException(); } }

		//
		// Summary:
		//     Returns the angle in degrees between two rotations a and b.
		//
		// Parameters:
		//   a:
		//
		//   b:
		public static float Angle(Quaternion a, Quaternion b) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a rotation which rotates angle degrees around axis.
		//
		// Parameters:
		//   angle:
		//
		//   axis:
		[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = true)]
		public static Quaternion AngleAxis(float angle, Vector3 axis) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
		public static Quaternion AxisAngle(Vector3 axis, float angle) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     The dot product between two rotations.
		//
		// Parameters:
		//   a:
		//
		//   b:
		public static float Dot(Quaternion a, Quaternion b) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a rotation that rotates z degrees around the z axis, x degrees around
		//     the x axis, and y degrees around the y axis.
		//
		// Parameters:
		//   euler:
		public static Quaternion Euler(Vector3 euler) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a rotation that rotates z degrees around the z axis, x degrees around
		//     the x axis, and y degrees around the y axis; applied in that order.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   z:
		public static Quaternion Euler(float x, float y, float z) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		public static Quaternion EulerAngles(float x, float y, float z) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		public static Quaternion EulerAngles(Vector3 euler) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		public static Quaternion EulerRotation(float x, float y, float z) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		public static Quaternion EulerRotation(Vector3 euler) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a rotation which rotates from fromDirection to toDirection.
		//
		// Parameters:
		//   fromDirection:
		//
		//   toDirection:
		[FreeFunction("FromToQuaternionSafe", IsThreadSafe = true)]
		public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns the Inverse of rotation.
		//
		// Parameters:
		//   rotation:
		[FreeFunction(IsThreadSafe = true)]
		public static Quaternion Inverse(Quaternion rotation) {
			return rotation.Conjugate().Scale(1 / rotation.Norm());
			throw new System.NotImplementedException();

		}

		public Quaternion Conjugate()
		{
			return new Quaternion(-x, -y, -z, w);

		}

		public Quaternion Scale(float s)
		{
			return new Quaternion(x * s, y * s, z * s, w * s);
		}

		public float Norm()
		{
			return (w * w + x * x + y * y + z * z);
		}



		//
		// Summary:
		//     Interpolates between a and b by t and normalizes the result afterwards. The parameter
		//     t is clamped to the range [0, 1].
		//
		// Parameters:
		//   a:
		//
		//   b:
		//
		//   t:
		[FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = true)]
		public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Interpolates between a and b by t and normalizes the result afterwards. The parameter
		//     t is not clamped.
		//
		// Parameters:
		//   a:
		//
		//   b:
		//
		//   t:
		[FreeFunction("QuaternionScripting::LerpUnclamped", IsThreadSafe = true)]
		public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a rotation with the specified forward and upwards directions.
		//
		// Parameters:
		//   forward:
		//     The direction to look in.
		//
		//   upwards:
		//     The vector that defines in which direction up is.
		[ExcludeFromDocs]
		public static Quaternion LookRotation(Vector3 forward) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a rotation with the specified forward and upwards directions.
		//
		// Parameters:
		//   forward:
		//     The direction to look in.
		//
		//   upwards:
		//     The vector that defines in which direction up is.
		[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = true)]
		public static Quaternion LookRotation(Vector3 forward, [DefaultValue("Vector3.up")] Vector3 upwards) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Converts this quaternion to one with the same orientation but with a magnitude
		//     of 1.
		//
		// Parameters:
		//   q:
		public static Quaternion Normalize(Quaternion q) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Rotates a rotation from towards to.
		//
		// Parameters:
		//   from:
		//
		//   to:
		//
		//   maxDegreesDelta:
		public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Spherically interpolates between a and b by t. The parameter t is clamped to
		//     the range [0, 1].
		//
		// Parameters:
		//   a:
		//
		//   b:
		//
		//   t:
		[FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = true)]
		public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Spherically interpolates between a and b by t. The parameter t is not clamped.
		//
		// Parameters:
		//   a:
		//
		//   b:
		//
		//   t:
		[FreeFunction("QuaternionScripting::SlerpUnclamped", IsThreadSafe = true)]
		public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees.")]
		public static Vector3 ToEulerAngles(Quaternion rotation) { throw new System.NotImplementedException(); }
		public bool Equals(Quaternion other) { throw new System.NotImplementedException(); }
		public override bool Equals(object other) { throw new System.NotImplementedException(); }
		public override int GetHashCode() { throw new System.NotImplementedException(); }
		public void Normalize() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Set x, y, z and w components of an existing Quaternion.
		//
		// Parameters:
		//   newX:
		//
		//   newY:
		//
		//   newZ:
		//
		//   newW:
		public void Set(float newX, float newY, float newZ, float newW) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees.")]
		public void SetAxisAngle(Vector3 axis, float angle) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		public void SetEulerAngles(Vector3 euler) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		public void SetEulerAngles(float x, float y, float z) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		public void SetEulerRotation(float x, float y, float z) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		public void SetEulerRotation(Vector3 euler) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a rotation which rotates from fromDirection to toDirection.
		//
		// Parameters:
		//   fromDirection:
		//
		//   toDirection:
		public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a rotation with the specified forward and upwards directions.
		//
		// Parameters:
		//   view:
		//     The direction to look in.
		//
		//   up:
		//     The vector that defines in which direction up is.
		public void SetLookRotation(Vector3 view, [DefaultValue("Vector3.up")] Vector3 up) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a rotation with the specified forward and upwards directions.
		//
		// Parameters:
		//   view:
		//     The direction to look in.
		//
		//   up:
		//     The vector that defines in which direction up is.
		[ExcludeFromDocs]
		public void SetLookRotation(Vector3 view) { throw new System.NotImplementedException(); }
		public void ToAngleAxis(out float angle, out Vector3 axis) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.ToAngleAxis instead. This function was deprecated because it uses radians instead of degrees.")]
		public void ToAxisAngle(out Vector3 axis, out float angle) { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees.")]
		public Vector3 ToEuler() { throw new System.NotImplementedException(); }
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees.")]
		public Vector3 ToEulerAngles() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a nicely formatted string of the Quaternion.
		//
		// Parameters:
		//   format:
		public string ToString(string format) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a nicely formatted string of the Quaternion.
		//
		// Parameters:
		//   format:
		public override string ToString() { throw new System.NotImplementedException(); }

		public static Vector3 operator *(Quaternion quat, Vector3 vec) {
			float num = quat.x * 2f;
			float num2 = quat.y * 2f;
			float num3 = quat.z * 2f;
			float num4 = quat.x * num;
			float num5 = quat.y * num2;
			float num6 = quat.z * num3;
			float num7 = quat.x * num2;
			float num8 = quat.x * num3;
			float num9 = quat.y * num3;
			float num10 = quat.w * num;
			float num11 = quat.w * num2;
			float num12 = quat.w * num3;
			Vector3 result;
			result.x = (1f - (num5 + num6)) * vec.x + (num7 - num12) * vec.y + (num8 + num11) * vec.z;
			result.y = (num7 + num12) * vec.x + (1f - (num4 + num6)) * vec.y + (num9 - num10) * vec.z;
			result.z = (num8 - num11) * vec.x + (num9 + num10) * vec.y + (1f - (num4 + num5)) * vec.z;
			return result;
		}
		public static Quaternion operator *(Quaternion lhs, Quaternion rhs) { throw new System.NotImplementedException(); }
		public static bool operator ==(Quaternion lhs, Quaternion rhs) { throw new System.NotImplementedException(); }
		public static bool operator !=(Quaternion lhs, Quaternion rhs) { throw new System.NotImplementedException(); }
	}
}