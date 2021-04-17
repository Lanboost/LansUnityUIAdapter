#region Assembly UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
namespace UnityEngine
{

	public struct RaycastHit
	{
		//
		// Summary:
		//     The Collider that was hit.
		public Collider collider { get { throw new System.NotImplementedException(); } }
		//
		// Summary:
		//     The impact point in world space where the ray hit the collider.
		public Vector3 point { get; set; }
		//
		// Summary:
		//     The normal of the surface the ray hit.
		public Vector3 normal { get; set; }
		//
		// Summary:
		//     The barycentric coordinate of the triangle we hit.
		public Vector3 barycentricCoordinate { get; set; }
		//
		// Summary:
		//     The distance from the ray's origin to the impact point.
		public float distance { get; set; }
		//
		// Summary:
		//     The index of the triangle that was hit.
		public int triangleIndex { get; }
		//
		// Summary:
		//     The uv texture coordinate at the collision location.
		public Vector2 textureCoord { get; }
		//
		// Summary:
		//     The secondary uv texture coordinate at the impact point.
		public Vector2 textureCoord2 { get; }
		[Obsolete("Use textureCoord2 instead. (UnityUpgradable) -> textureCoord2")]
		public Vector2 textureCoord1 { get; }
		//
		// Summary:
		//     The Transform of the rigidbody or collider that was hit.
		public Transform transform { get; }
		//
		// Summary:
		//     The Rigidbody of the collider that was hit. If the collider is not attached to
		//     a rigidbody then it is null.
		//public Rigidbody rigidbody { get { throw new System.NotImplementedException(); } }
		//
		// Summary:
		//     The uv lightmap coordinate at the impact point.
		public Vector2 lightmapCoord { get; }
	}
}