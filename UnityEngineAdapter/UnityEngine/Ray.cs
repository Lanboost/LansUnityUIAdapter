#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
	//
	// Summary:
	//     Representation of rays.
	public struct Ray
	{
		//
		// Summary:
		//     Creates a ray starting at origin along direction.
		//
		// Parameters:
		//   origin:
		//
		//   direction:
		public Ray(Vector3 origin, Vector3 direction) { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     The origin point of the ray.
		public Vector3 origin { get; set; }
		//
		// Summary:
		//     The direction of the ray.
		public Vector3 direction { get; set; }

		//
		// Summary:
		//     Returns a point at distance units along the ray.
		//
		// Parameters:
		//   distance:
		public Vector3 GetPoint(float distance) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a nicely formatted string for this ray.
		//
		// Parameters:
		//   format:
		public override string ToString() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a nicely formatted string for this ray.
		//
		// Parameters:
		//   format:
		public string ToString(string format) { throw new System.NotImplementedException(); }
	}
}