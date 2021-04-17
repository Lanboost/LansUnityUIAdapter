#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
namespace UnityEngine { 

	public struct Color32
	{
		//
		// Summary:
		//     Red component of the color.
		public byte r;
		//
		// Summary:
		//     Green component of the color.
		public byte g;
		//
		// Summary:
		//     Blue component of the color.
		public byte b;
		//
		// Summary:
		//     Alpha component of the color.
		public byte a;

		//
		// Summary:
		//     Constructs a new Color32 with given r, g, b, a components.
		//
		// Parameters:
		//   r:
		//
		//   g:
		//
		//   b:
		//
		//   a:
		public Color32(byte r, byte g, byte b, byte a) {
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		public byte this[int index] { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }

		//
		// Summary:
		//     Linearly interpolates between colors a and b by t.
		//
		// Parameters:
		//   a:
		//
		//   b:
		//
		//   t:
		public static Color32 Lerp(Color32 a, Color32 b, float t) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Linearly interpolates between colors a and b by t.
		//
		// Parameters:
		//   a:
		//
		//   b:
		//
		//   t:
		public static Color32 LerpUnclamped(Color32 a, Color32 b, float t) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a nicely formatted string of this color.
		//
		// Parameters:
		//   format:
		//public override string ToString() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a nicely formatted string of this color.
		//
		// Parameters:
		//   format:
		//public string ToString(string format) { throw new System.NotImplementedException(); }

		public static implicit operator Color32(Color c) {
			return new Color32(
				(byte)Math.Min(255, Math.Max(0,(int) (c.r*255))),
				(byte)Math.Min(255, Math.Max(0,(int) (c.g*255))),
				(byte)Math.Min(255, Math.Max(0,(int) (c.b*255))),
				(byte)Math.Min(255, Math.Max(0,(int) (c.a*255)))
			);
		}
		public static implicit operator Color(Color32 c) {
			var v = new Color(c.r / 255f, c.g / 255f, c.b / 255f, c.a / 255f);
			return v;
		}
	}
}