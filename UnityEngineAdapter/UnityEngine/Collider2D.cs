#region Assembly UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System.Collections.Generic;
namespace UnityEngine
{
	public class Collider2D : Behaviour
	{
		public Collider2D() { }

		//
		// Summary:
		//     Get the bounciness used by the collider.
		public float bounciness { get; }
		//
		// Summary:
		//     Get the friction used by the collider.
		public float friction { get; }
		//
		// Summary:
		//     The density of the collider used to calculate its mass (when auto mass is enabled).
		public float density { get; set; }
		//
		// Summary:
		//     Whether the collider is used by an attached effector or not.
		public bool usedByEffector { get; set; }
		//
		// Summary:
		//     Sets whether the Collider will be used or not used by a CompositeCollider2D.
		public bool usedByComposite { get; set; }
		//
		// Summary:
		//     Is this collider configured as a trigger?
		public bool isTrigger { get; set; }
		//
		// Summary:
		//     The local offset of the collider geometry.
		public Vector2 offset { get; set; }
		/*
		//
		// Summary:
		//     The Rigidbody2D attached to the Collider2D.
		public Rigidbody2D attachedRigidbody { get; }
		//
		// Summary:
		//     The number of separate shaped regions in the collider.
		public int shapeCount { get; }
		//
		// Summary:
		//     The world space bounding area of the collider.
		public Bounds bounds { get; }
		//
		// Summary:
		//     The PhysicsMaterial2D that is applied to this collider.
		public PhysicsMaterial2D sharedMaterial { get; set; }
		//
		// Summary:
		//     Get the CompositeCollider2D that is available to be attached to the collider.
		public CompositeCollider2D composite { get; }

		[ExcludeFromDocs]
		public int Cast(Vector2 direction, RaycastHit2D[] results, float distance);
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity, [DefaultValue("true")] bool ignoreSiblingColliders = true);
		//
		// Summary:
		//     Casts the Collider shape into the Scene starting at the Collider position ignoring
		//     the Collider itself.
		//
		// Parameters:
		//   direction:
		//     Vector representing the direction to cast the shape.
		//
		//   contactFilter:
		//     Filter results defined by the contact filter.
		//
		//   results:
		//     Array to receive results.
		//
		//   distance:
		//     Maximum distance over which to cast the shape.
		//
		//   ignoreSiblingColliders:
		//     Determines whether the cast should ignore Colliders attached to the same Rigidbody2D
		//     (known as sibling Colliders).
		//
		// Returns:
		//     The number of results returned.
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("true")] bool ignoreSiblingColliders);
		[ExcludeFromDocs]
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
		//
		// Summary:
		//     Casts the Collider shape into the Scene starting at the Collider position ignoring
		//     the Collider itself.
		//
		// Parameters:
		//   direction:
		//     Vector representing the direction to cast the shape.
		//
		//   results:
		//     Array to receive results.
		//
		//   distance:
		//     Maximum distance over which to cast the shape.
		//
		//   ignoreSiblingColliders:
		//     Determines whether the cast should ignore Colliders attached to the same Rigidbody2D
		//     (known as sibling Colliders).
		//
		// Returns:
		//     The number of results returned.
		public int Cast(Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("true")] bool ignoreSiblingColliders);
		[ExcludeFromDocs]
		public int Cast(Vector2 direction, RaycastHit2D[] results);
		[ExcludeFromDocs]
		public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance);
		//
		// Summary:
		//     Returns a point on the perimeter of this Collider that is closest to the specified
		//     position.
		//
		// Parameters:
		//   position:
		//     The position from which to find the closest point on this Collider.
		//
		// Returns:
		//     A point on the perimeter of this Collider that is closest to the specified position.
		public Vector2 ClosestPoint(Vector2 position);
		//
		// Summary:
		//     Creates a planar Mesh that is identical to the area defined by the Collider2D
		//     geometry.
		//
		// Parameters:
		//   useBodyPosition:
		//     Should the mesh be transformed by the position of the attached Rigidbody2D?
		//
		//   useBodyRotation:
		//     Should the mesh be transformed by the rotation of the attached Rigidbody2D?
		//
		// Returns:
		//     The planar Mesh created that matches the collider geometry or NULL if no Mesh
		//     could be created.
		[NativeMethod("CreateMesh_Binding")]
		public Mesh CreateMesh(bool useBodyPosition, bool useBodyRotation);
		//
		// Summary:
		//     Calculates the minimum separation of this collider against another collider.
		//
		// Parameters:
		//   collider:
		//     A collider used to calculate the minimum separation against this collider.
		//
		// Returns:
		//     The minimum separation of collider and this collider.
		public ColliderDistance2D Distance([Writable] Collider2D collider);
		//
		// Summary:
		//     Retrieves all contact points for this Collider.
		//
		// Parameters:
		//   contacts:
		//     An array of ContactPoint2D used to receive the results.
		//
		// Returns:
		//     Returns the number of contacts placed in the contacts array.
		public int GetContacts(ContactPoint2D[] contacts);
		public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders);
		//
		// Summary:
		//     Retrieves all colliders in contact with this Collider, with the results filtered
		//     by the contactFilter.
		//
		// Parameters:
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		//   colliders:
		//     An array of Collider2D used to receive the results.
		//
		// Returns:
		//     Returns the number of colliders placed in the colliders array.
		public int GetContacts(ContactFilter2D contactFilter, Collider2D[] colliders);
		//
		// Summary:
		//     Retrieves all contact points for this Collider, with the results filtered by
		//     the contactFilter.
		//
		// Parameters:
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		//   contacts:
		//     An array of ContactPoint2D used to receive the results.
		//
		// Returns:
		//     Returns the number of contacts placed in the contacts array.
		public int GetContacts(ContactFilter2D contactFilter, ContactPoint2D[] contacts);
		public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts);
		//
		// Summary:
		//     Retrieves all colliders in contact with this Collider.
		//
		// Parameters:
		//   colliders:
		//     An array of Collider2D used to receive the results.
		//
		// Returns:
		//     Returns the number of contacts placed in the colliders array.
		public int GetContacts(Collider2D[] colliders);
		public int GetContacts(List<ContactPoint2D> contacts);
		public int GetContacts(List<Collider2D> colliders);
		//
		// Summary:
		//     Generates a simple hash value based upon the geometry of the Collider2D.
		//
		// Returns:
		//     A hash value that uniquely identifies the configured geometry of the Collider2D.
		[NativeMethod("GetShapeHash_Binding")]
		public uint GetShapeHash();
		//
		// Summary:
		//     Check whether this collider is touching the collider or not.
		//
		// Parameters:
		//   collider:
		//     The collider to check if it is touching this collider.
		//
		// Returns:
		//     Whether this collider is touching the collider or not.
		public bool IsTouching([NotNull][Writable] Collider2D collider);
		//
		// Summary:
		//     Check whether this collider is touching the collider or not with the results
		//     filtered by the contactFilter.
		//
		// Parameters:
		//   collider:
		//     The collider to check if it is touching this collider.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		// Returns:
		//     Whether this collider is touching the collider or not.
		public bool IsTouching([Writable] Collider2D collider, ContactFilter2D contactFilter);
		//
		// Summary:
		//     Check whether this collider is touching other colliders or not with the results
		//     filtered by the contactFilter.
		//
		// Parameters:
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		// Returns:
		//     Whether this collider is touching the collider or not.
		public bool IsTouching(ContactFilter2D contactFilter);
		[ExcludeFromDocs]
		public bool IsTouchingLayers();
		//
		// Summary:
		//     Checks whether this collider is touching any colliders on the specified layerMask
		//     or not.
		//
		// Parameters:
		//   layerMask:
		//     Any colliders on any of these layers count as touching.
		//
		// Returns:
		//     Whether this collider is touching any collider on the specified layerMask or
		//     not.
		public bool IsTouchingLayers([DefaultValue("Physics2D.AllLayers")] int layerMask);
		public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results);
		//
		// Summary:
		//     Get a list of all colliders that overlap this collider.
		//
		// Parameters:
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth. Note that normal angle is not used for overlap testing.
		//
		//   results:
		//     The array to receive results. The size of the array determines the maximum number
		//     of results that can be returned.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public int OverlapCollider(ContactFilter2D contactFilter, Collider2D[] results);
		//
		// Summary:
		//     Check if a collider overlaps a point in space.
		//
		// Parameters:
		//   point:
		//     A point in world space.
		//
		// Returns:
		//     Does point overlap the collider?
		public bool OverlapPoint(Vector2 point);
		[ExcludeFromDocs]
		public int Raycast(Vector2 direction, RaycastHit2D[] results);
		[ExcludeFromDocs]
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
		//
		// Summary:
		//     Casts a ray into the Scene that starts at the Collider position and ignores the
		//     Collider itself.
		//
		// Parameters:
		//   direction:
		//     Vector representing the direction of the ray.
		//
		//   results:
		//     Array to receive results.
		//
		//   distance:
		//     Maximum distance over which to cast the ray.
		//
		//   layerMask:
		//     Filter to check objects only on specific layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than this value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than this value.
		//
		//   contactFilter:
		//     Filter results defined by the contact filter.
		//
		// Returns:
		//     The number of results returned.
		public int Raycast(Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("Physics2D.AllLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
		[ExcludeFromDocs]
		public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance);
		//
		// Summary:
		//     Casts a ray into the Scene that starts at the Collider position and ignores the
		//     Collider itself.
		//
		// Parameters:
		//   direction:
		//     Vector representing the direction of the ray.
		//
		//   results:
		//     Array to receive results.
		//
		//   distance:
		//     Maximum distance over which to cast the ray.
		//
		//   layerMask:
		//     Filter to check objects only on specific layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than this value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than this value.
		//
		//   contactFilter:
		//     Filter results defined by the contact filter.
		//
		// Returns:
		//     The number of results returned.
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance);
		public int Raycast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity);
		*/
	
	}
}