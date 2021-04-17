#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;

namespace UnityEngine
{

	public struct Color : IEquatable<Color>
	{
		//
		// Summary:
		//     Red component of the color.
		public float r;
		//
		// Summary:
		//     Green component of the color.
		public float g;
		//
		// Summary:
		//     Blue component of the color.
		public float b;
		//
		// Summary:
		//     Alpha component of the color (0 is transparent, 1 is opaque).
		public float a;

		//
		// Summary:
		//     Constructs a new Color with given r,g,b components and sets a to 1.
		//
		// Parameters:
		//   r:
		//     Red component.
		//
		//   g:
		//     Green component.
		//
		//   b:
		//     Blue component.
		public Color(float r, float g, float b) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Constructs a new Color with given r,g,b,a components.
		//
		// Parameters:
		//   r:
		//     Red component.
		//
		//   g:
		//     Green component.
		//
		//   b:
		//     Blue component.
		//
		//   a:
		//     Alpha component.
		public Color(float r, float g, float b, float a) {
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
			this.grayscale = 0;
			this.maxColorComponent = 0;
		}

		public float this[int index] { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }

		//
		// Summary:
		//     Cyan. RGBA is (0, 1, 1, 1).
		public static Color cyan { get; }
		//
		// Summary:
		//     Completely transparent. RGBA is (0, 0, 0, 0).
		public static Color clear { get; }
		//
		// Summary:
		//     English spelling for gray. RGBA is the same (0.5, 0.5, 0.5, 1).
		public static Color grey { get; }
		//
		// Summary:
		//     Gray. RGBA is (0.5, 0.5, 0.5, 1).
		public static Color gray { get; }
		//
		// Summary:
		//     Magenta. RGBA is (1, 0, 1, 1).
		public static Color magenta { get; }
		//
		// Summary:
		//     Solid red. RGBA is (1, 0, 0, 1).
		public static Color red { get; }
		//
		// Summary:
		//     Yellow. RGBA is (1, 0.92, 0.016, 1), but the color is nice to look at!
		public static Color yellow { get; }
		//
		// Summary:
		//     Solid black. RGBA is (0, 0, 0, 1).
		public static Color black { get; }
		//
		// Summary:
		//     Solid white. RGBA is (1, 1, 1, 1).
		public static Color white { get => new Color(1,1,1,1); }
		//
		// Summary:
		//     Solid green. RGBA is (0, 1, 0, 1).
		public static Color green { get; }
		//
		// Summary:
		//     Solid blue. RGBA is (0, 0, 1, 1).
		public static Color blue { get; }
		//
		// Summary:
		//     A version of the color that has had the gamma curve applied.
		public Color gamma { get { throw new System.NotImplementedException(); } }
		//
		// Summary:
		//     A linear value of an sRGB color.
		public Color linear { get { throw new System.NotImplementedException(); } }
		//
		// Summary:
		//     The grayscale value of the color. (Read Only)
		public float grayscale { get; }
		//
		// Summary:
		//     Returns the maximum color component value: Max(r,g,b).
		public float maxColorComponent { get; }

		//
		// Summary:
		//     Creates an RGB colour from HSV input.
		//
		// Parameters:
		//   H:
		//     Hue [0..1].
		//
		//   S:
		//     Saturation [0..1].
		//
		//   V:
		//     Brightness value [0..1].
		//
		//   hdr:
		//     Output HDR colours. If true, the returned colour will not be clamped to [0..1].
		//
		// Returns:
		//     An opaque colour with HSV matching the input.
		public static Color HSVToRGB(float H, float S, float V) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates an RGB colour from HSV input.
		//
		// Parameters:
		//   H:
		//     Hue [0..1].
		//
		//   S:
		//     Saturation [0..1].
		//
		//   V:
		//     Brightness value [0..1].
		//
		//   hdr:
		//     Output HDR colours. If true, the returned colour will not be clamped to [0..1].
		//
		// Returns:
		//     An opaque colour with HSV matching the input.
		public static Color HSVToRGB(float H, float S, float V, bool hdr) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Linearly interpolates between colors a and b by t.
		//
		// Parameters:
		//   a:
		//     Color a.
		//
		//   b:
		//     Color b.
		//
		//   t:
		//     Float for combining a and b.
		public static Color Lerp(Color a, Color b, float t) {
			return new Color(
				Mathf.Lerp(a.r, b.r, t),	
				Mathf.Lerp(a.g, b.g, t),	
				Mathf.Lerp(a.b, b.b, t),	
				Mathf.Lerp(a.a, b.a, t)	
			);
		}
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
		public static Color LerpUnclamped(Color a, Color b, float t) { throw new System.NotImplementedException(); }
		public static void RGBToHSV(Color rgbColor, out float H, out float S, out float V) { throw new System.NotImplementedException(); }
		public bool Equals(Color other) {
			return this.r == other.r &&
			this.g == other.g &&
			this.b == other.b &&
			this.a == other.a; 
		}
		public override bool Equals(object other) { throw new System.NotImplementedException(); }
		public override int GetHashCode() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a nicely formatted string of this color.
		//
		// Parameters:
		//   format:
		public override string ToString() {
			return $"Color({r},{g},{b},{a})";
		}
		//
		// Summary:
		//     Returns a nicely formatted string of this color.
		//
		// Parameters:
		//   format:
		public string ToString(string format) { throw new System.NotImplementedException(); }

		public static Color operator +(Color a, Color b) { throw new System.NotImplementedException(); }
		public static Color operator -(Color a, Color b) { throw new System.NotImplementedException(); }
		public static Color operator *(float b, Color a) {
			return a*b;
		}
		public static Color operator *(Color a, float b) {
			return new Color(
				Mathf.Max(0,Mathf.Min(1,a.r*b)),
				Mathf.Max(0,Mathf.Min(1,a.g*b)),
				Mathf.Max(0,Mathf.Min(1,a.b*b)),
				Mathf.Max(0,Mathf.Min(1,a.a*b))
			);
		}
		public static Color operator *(Color a, Color b) {
			return new Color(a.r * b.r, a.g * b.g, a.b * b.b, a.a * b.a);
		}
		public static Color operator /(Color a, float b) { throw new System.NotImplementedException(); }
		public static bool operator ==(Color lhs, Color rhs) {
			return
				lhs.r == rhs.r &&
				lhs.g == rhs.g &&
				lhs.b == rhs.b &&
				lhs.a == rhs.a;
		}
		public static bool operator !=(Color lhs, Color rhs) {
			return
				lhs.r != rhs.r ||
				lhs.g != rhs.g ||
				lhs.b != rhs.b ||
				lhs.a != rhs.a;
		}

		public static implicit operator Color(Vector4 v) { throw new System.NotImplementedException(); }
		public static implicit operator Vector4(Color c) { throw new System.NotImplementedException(); }
	}
}