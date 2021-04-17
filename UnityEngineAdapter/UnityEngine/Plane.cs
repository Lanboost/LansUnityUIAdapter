#region Assembly UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion


namespace UnityEngine
{
	//
	// Summary:
	//     Representation of a plane in 3D space.

	public struct Plane
	{
		//
		// Summary:
		//     Creates a plane.
		//
		// Parameters:
		//   inNormal:
		//
		//   inPoint:
		public Plane(Vector3 inNormal, Vector3 inPoint) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a plane.
		//
		// Parameters:
		//   inNormal:
		//
		//   d:
		public Plane(Vector3 inNormal, float d) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Creates a plane.
		//
		// Parameters:
		//   a:
		//
		//   b:
		//
		//   c:
		public Plane(Vector3 a, Vector3 b, Vector3 c) { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     Normal vector of the plane.
		public Vector3 normal { get; set; }
		//
		// Summary:
		//     Distance from the origin to the plane.
		public float distance { get; set; }
		//
		// Summary:
		//     Returns a copy of the plane that faces in the opposite direction.
		public Plane flipped { get { throw new System.NotImplementedException(); } }

		//
		// Summary:
		//     Returns a copy of the given plane that is moved in space by the given translation.
		//
		// Parameters:
		//   plane:
		//     The plane to move in space.
		//
		//   translation:
		//     The offset in space to move the plane with.
		//
		// Returns:
		//     The translated plane.
		public static Plane Translate(Plane plane, Vector3 translation) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     For a given point returns the closest point on the plane.
		//
		// Parameters:
		//   point:
		//     The point to project onto the plane.
		//
		// Returns:
		//     A point on the plane that is closest to point.
		public Vector3 ClosestPointOnPlane(Vector3 point) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Makes the plane face in the opposite direction.
		public void Flip() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a signed distance from plane to point.
		//
		// Parameters:
		//   point:
		public float GetDistanceToPoint(Vector3 point) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Is a point on the positive side of the plane?
		//
		// Parameters:
		//   point:
		public bool GetSide(Vector3 point) { throw new System.NotImplementedException(); }
		public bool Raycast(Ray ray, out float enter) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Are two points on the same side of the plane?
		//
		// Parameters:
		//   inPt0:
		//
		//   inPt1:
		public bool SameSide(Vector3 inPt0, Vector3 inPt1) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a plane using three points that lie within it. The points go around clockwise
		//     as you look down on the top surface of the plane.
		//
		// Parameters:
		//   a:
		//     First point in clockwise order.
		//
		//   b:
		//     Second point in clockwise order.
		//
		//   c:
		//     Third point in clockwise order.
		public void Set3Points(Vector3 a, Vector3 b, Vector3 c) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets a plane using a point that lies within it along with a normal to orient
		//     it.
		//
		// Parameters:
		//   inNormal:
		//     The plane's normal vector.
		//
		//   inPoint:
		//     A point that lies on the plane.
		public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint) { throw new System.NotImplementedException(); }
		public override string ToString() { throw new System.NotImplementedException(); }
		public string ToString(string format) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Moves the plane in space by the translation vector.
		//
		// Parameters:
		//   translation:
		//     The offset in space to move the plane with.
		public void Translate(Vector3 translation) { throw new System.NotImplementedException(); }
	}
}