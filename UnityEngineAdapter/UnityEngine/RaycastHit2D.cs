#region Assembly UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion


namespace UnityEngine
{

	public struct RaycastHit2D
	{
		//
		// Summary:
		//     The centroid of the primitive used to perform the cast.
		public Vector2 centroid { get; set; }
		//
		// Summary:
		//     The point in world space where the ray hit the collider's surface.
		public Vector2 point { get; set; }
		//
		// Summary:
		//     The normal vector of the surface hit by the ray.
		public Vector2 normal { get; set; }
		//
		// Summary:
		//     The distance from the ray origin to the impact point.
		public float distance { get; set; }
		//
		// Summary:
		//     Fraction of the distance along the ray that the hit occurred.
		public float fraction { get; set; }
		//
		// Summary:
		//     The collider hit by the ray.
		public Collider2D collider { get; }
		//
		// Summary:
		//     The Rigidbody2D attached to the object that was hit.
		//public Rigidbody2D rigidbody { get; }
		//
		// Summary:
		//     The Transform of the object that was hit.
		public Transform transform { get; }

		public int CompareTo(RaycastHit2D other) { throw new System.NotImplementedException(); }

		public static implicit operator bool(RaycastHit2D hit) { throw new System.NotImplementedException(); }
	}
}