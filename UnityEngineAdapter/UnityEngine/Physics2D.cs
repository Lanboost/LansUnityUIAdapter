#region Assembly UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine
{
	public class Physics2D
	{
		//
		// Summary:
		//     Layer mask constant for the default layer that ignores raycasts.
		public const int IgnoreRaycastLayer = 4;
		//
		// Summary:
		//     Layer mask constant that includes all layers participating in raycasts by default.
		public const int DefaultRaycastLayers = -5;
		//
		// Summary:
		//     Layer mask constant that includes all layers.
		public const int AllLayers = -1;

		public Physics2D() { throw new System.NotImplementedException(); }

		/*
		//
		// Summary:
		//     The number of iterations of the physics solver when considering objects' velocities.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static int velocityIterations { get; set; }
		//
		// Summary:
		//     The number of iterations of the physics solver when considering objects' positions.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static int positionIterations { get; set; }
		//
		// Summary:
		//     Acceleration due to gravity.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static Vector2 gravity { get; set; }
		//
		// Summary:
		//     Do raycasts detect Colliders configured as triggers?
		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool queriesHitTriggers { get; set; }
		//
		// Summary:
		//     Sets the raycasts or linecasts that start inside Colliders to detect or not detect
		//     those Colliders.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool queriesStartInColliders { get; set; }
		//
		// Summary:
		//     The maximum angular speed of a rigid-body per physics update. Increasing this
		//     can cause numerical problems.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float maxRotationSpeed { get; set; }
		//
		// Summary:
		//     Determines whether the garbage collector should reuse only a single instance
		//     of a Collision2D type for all collision callbacks.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool reuseCollisionCallbacks { get; set; }
		//
		// Summary:
		//     Whether or not to automatically sync transform changes with the physics system
		//     whenever a Transform component changes.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool autoSyncTransforms { get; set; }
		//
		// Summary:
		//     Sets whether the physics should be simulated automatically or not.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool autoSimulation { get; set; }
		//
		// Summary:
		//     A set of options that control how physics operates when using the job system
		//     to multithread the physics simulation.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static PhysicsJobOptions2D jobOptions { get; set; }
		//
		// Summary:
		//     Any collisions with a relative linear velocity below this threshold will be treated
		//     as inelastic.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float velocityThreshold { get; set; }
		//
		// Summary:
		//     The maximum linear position correction used when solving constraints. This helps
		//     to prevent overshoot.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float maxLinearCorrection { get; set; }
		//
		// Summary:
		//     The maximum angular position correction used when solving constraints. This helps
		//     to prevent overshoot.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float maxAngularCorrection { get; set; }
		//
		// Summary:
		//     The maximum linear speed of a rigid-body per physics update. Increasing this
		//     can cause numerical problems.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float maxTranslationSpeed { get; set; }
		//
		// Summary:
		//     The PhysicsScene2D automatically created when Unity starts.
		public static PhysicsScene2D defaultPhysicsScene { get; }
		//
		// Summary:
		//     Use this to control whether or not the appropriate OnCollisionExit2D or OnTriggerExit2D
		//     callbacks should be called when a Collider2D is disabled.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool callbacksOnDisable { get; set; }
		//
		// Summary:
		//     The scale factor that controls how fast overlaps are resolved.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float baumgarteScale { get; set; }
		//
		// Summary:
		//     The scale factor that controls how fast TOI overlaps are resolved.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float baumgarteTOIScale { get; set; }
		//
		// Summary:
		//     Ets the collision callbacks to stop or continue processing if any of the objects
		//     involved in the collision are deleted.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Physics2D.deleteStopsCallbacks is deprecated.(UnityUpgradable) -> changeStopsCallbacks", true)]
		public static bool deleteStopsCallbacks { get; set; }
		//
		// Summary:
		//     Do ray/line casts that start inside a collider(s) detect those collider(s)?
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Physics2D.raycastsStartInColliders is deprecated. Use Physics2D.queriesStartInColliders instead. (UnityUpgradable) -> queriesStartInColliders", true)]
		public static bool raycastsStartInColliders { get; set; }
		//
		// Summary:
		//     Sets the raycasts to either detect or not detect Triggers.
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Physics2D.raycastsHitTriggers is deprecated. Use Physics2D.queriesHitTriggers instead. (UnityUpgradable) -> queriesHitTriggers", true)]
		public static bool raycastsHitTriggers { get; set; }
		//
		// Summary:
		//     Sets the color used by the gizmos to show all Collider axis-aligned bounding
		//     boxes (AABBs).
		[StaticAccessor("GetPhysics2DSettings()")]
		public static Color colliderAABBColor { get; set; }
		//
		// Summary:
		//     The color used by the gizmos to show all collider contacts.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static Color colliderContactColor { get; set; }
		//
		// Summary:
		//     The color used by the gizmos to show all asleep colliders (collider is asleep
		//     when the body is asleep).
		[StaticAccessor("GetPhysics2DSettings()")]
		public static Color colliderAsleepColor { get; set; }
		//
		// Summary:
		//     The color used by the gizmos to show all awake colliders (collider is awake when
		//     the body is awake).
		[StaticAccessor("GetPhysics2DSettings()")]
		public static Color colliderAwakeColor { get; set; }
		//
		// Summary:
		//     The scale of the contact arrow used by the collider gizmos.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float contactArrowScale { get; set; }
		//
		// Summary:
		//     Should the collider gizmos show the AABBs for each collider?
		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool showColliderAABB { get; set; }
		//
		// Summary:
		//     Should the collider gizmos show current contacts for each collider?
		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool showColliderContacts { get; set; }
		//
		// Summary:
		//     Should the collider gizmos show the sleep-state for each collider?
		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool showColliderSleep { get; set; }
		//
		// Summary:
		//     Should the collider gizmos always be shown even when they are not selected?
		[StaticAccessor("GetPhysics2DSettings()")]
		public static bool alwaysShowColliders { get; set; }
		//
		// Summary:
		//     A rigid-body cannot sleep if its angular velocity is above this tolerance.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float angularSleepTolerance { get; set; }
		//
		// Summary:
		//     A rigid-body cannot sleep if its linear velocity is above this tolerance.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float linearSleepTolerance { get; set; }
		//
		// Summary:
		//     The time in seconds that a rigid-body must be still before it will go to sleep.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float timeToSleep { get; set; }
		//
		// Summary:
		//     The default contact offset of the newly created colliders.
		[StaticAccessor("GetPhysics2DSettings()")]
		public static float defaultContactOffset { get; set; }
		//
		// Summary:
		//     Whether or not to stop reporting collision callbacks immediately if any of the
		//     objects involved in the collision are deleted/moved.
		[Obsolete("Physics2D.changeStopsCallbacks is deprecated and will always return false.", false)]
		public static bool changeStopsCallbacks { get; set; }
		//
		// Summary:
		//     This property is obsolete. You should use defaultContactOffset instead.
		[Obsolete("Physics2D.minPenetrationForPenalty is deprecated. Use Physics2D.defaultContactOffset instead. (UnityUpgradable) -> defaultContactOffset", false)]
		public static float minPenetrationForPenalty { get; set; }

		[ExcludeFromDocs]
		public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask);
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
		//
		// Summary:
		//     Casts a box against colliders in the Scene, returning the first collider to contact
		//     with it.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the box originates.
		//
		//   size:
		//     The size of the box.
		//
		//   angle:
		//     The angle of the box (in degrees).
		//
		//   direction:
		//     A vector representing the direction of the box.
		//
		//   distance:
		//     The maximum distance over which to cast the box.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The cast results returned.
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("Physics2D.AllLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		//
		// Summary:
		//     Casts a box against the Colliders in the Scene and returns all Colliders that
		//     are in contact with it.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the box originates.
		//
		//   size:
		//     The size of the box.
		//
		//   angle:
		//     The angle of the box (in degrees).
		//
		//   direction:
		//     A vector representing the direction of the box.
		//
		//   distance:
		//     The maximum distance over which to cast the box.
		//
		//   results:
		//     The array to receive results. The size of the array determines the maximum number
		//     of results that can be returned.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [Internal.DefaultValue("Mathf.Infinity")] float distance);
		public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Internal.DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity);
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance);
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction);
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance);
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction);
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask);
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
		//
		// Summary:
		//     Casts a box against colliders in the Scene, returning all colliders that contact
		//     with it.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the box originates.
		//
		//   size:
		//     The size of the box.
		//
		//   angle:
		//     The angle of the box (in degrees).
		//
		//   direction:
		//     A vector representing the direction of the box.
		//
		//   distance:
		//     The maximum distance over which to cast the box.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The cast results returned.
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		//
		// Summary:
		//     Casts a box into the Scene, returning colliders that contact with it into the
		//     provided results array.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the box originates.
		//
		//   size:
		//     The size of the box.
		//
		//   angle:
		//     The angle of the box (in degrees).
		//
		//   direction:
		//     A vector representing the direction of the box.
		//
		//   results:
		//     Array to receive results.
		//
		//   distance:
		//     The maximum distance over which to cast the box.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance);
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results);
		[ExcludeFromDocs]
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction);
		[ExcludeFromDocs]
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask);
		//
		// Summary:
		//     Casts a capsule against colliders in the Scene, returning the first collider
		//     to contact with it.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the capsule originates.
		//
		//   size:
		//     The size of the capsule.
		//
		//   capsuleDirection:
		//     The direction of the capsule.
		//
		//   angle:
		//     The angle of the capsule (in degrees).
		//
		//   direction:
		//     Vector representing the direction to cast the capsule.
		//
		//   distance:
		//     The maximum distance over which to cast the capsule.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than this value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than this value.
		//
		// Returns:
		//     The cast results returned.
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
		//
		// Summary:
		//     Casts a capsule against the colliders in the Scene and returns all colliders
		//     that are in contact with it.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the capsule originates.
		//
		//   size:
		//     The size of the capsule.
		//
		//   capsuleDirection:
		//     The direction of the capsule.
		//
		//   angle:
		//     The angle of the capsule (in degrees).
		//
		//   direction:
		//     Vector representing the direction to cast the capsule.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		//   results:
		//     The array to receive results. The size of the array determines the maximum number
		//     of results that can be returned.
		//
		//   distance:
		//     The maximum distance over which to cast the capsule.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [Internal.DefaultValue("Mathf.Infinity")] float distance);
		public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Internal.DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity);
		[ExcludeFromDocs]
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance);
		[ExcludeFromDocs]
		public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction);
		[ExcludeFromDocs]
		public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask);
		[ExcludeFromDocs]
		public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
		//
		// Summary:
		//     Casts a capsule against colliders in the Scene, returning all colliders that
		//     contact with it.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the capsule originates.
		//
		//   size:
		//     The size of the capsule.
		//
		//   capsuleDirection:
		//     The direction of the capsule.
		//
		//   angle:
		//     The angle of the capsule (in degrees).
		//
		//   direction:
		//     Vector representing the direction to cast the capsule.
		//
		//   distance:
		//     The maximum distance over which to cast the capsule.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than this value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than this value.
		//
		// Returns:
		//     The cast results returned.
		public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance);
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results);
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance);
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
		[ExcludeFromDocs]
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
		//
		// Summary:
		//     Casts a capsule into the Scene, returning colliders that contact with it into
		//     the provided results array.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the capsule originates.
		//
		//   size:
		//     The size of the capsule.
		//
		//   capsuleDirection:
		//     The direction of the capsule.
		//
		//   angle:
		//     The angle of the capsule (in degrees).
		//
		//   direction:
		//     Vector representing the direction to cast the capsule.
		//
		//   results:
		//     Array to receive results.
		//
		//   distance:
		//     The maximum distance over which to cast the capsule.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than this value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than this value.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction);
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance);
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask);
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
		//
		// Summary:
		//     Casts a circle against colliders in the Scene, returning all colliders that contact
		//     with it.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the circle originates.
		//
		//   radius:
		//     The radius of the circle.
		//
		//   direction:
		//     A vector representing the direction of the circle.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		//   results:
		//     The array to receive results. The size of the array determines the maximum number
		//     of results that can be returned.
		//
		//   distance:
		//     The maximum distance over which to cast the circle.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [Internal.DefaultValue("Mathf.Infinity")] float distance);
		public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Internal.DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity);
		//
		// Summary:
		//     Casts a circle against colliders in the Scene, returning the first collider to
		//     contact with it.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the circle originates.
		//
		//   radius:
		//     The radius of the circle.
		//
		//   direction:
		//     A vector representing the direction of the circle.
		//
		//   distance:
		//     The maximum distance over which to cast the circle.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The cast results returned.
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction);
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance);
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask);
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth);
		//
		// Summary:
		//     Casts a circle against colliders in the Scene, returning all colliders that contact
		//     with it.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the circle originates.
		//
		//   radius:
		//     The radius of the circle.
		//
		//   direction:
		//     A vector representing the direction of the circle.
		//
		//   distance:
		//     The maximum distance over which to cast the circle.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The cast results returned.
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		//
		// Summary:
		//     Casts a circle into the Scene, returning colliders that contact with it into
		//     the provided results array.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the circle originates.
		//
		//   radius:
		//     The radius of the circle.
		//
		//   direction:
		//     A vector representing the direction of the circle.
		//
		//   results:
		//     Array to receive results.
		//
		//   distance:
		//     The maximum distance over which to cast the circle.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance);
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results);
		//
		// Summary:
		//     Returns a point on the perimeter of the collider that is closest to the specified
		//     position.
		//
		// Parameters:
		//   position:
		//     The position from which to find the closest point on the specified collider.
		//
		//   collider:
		//     The Collider on which to find the closest specified position.
		//
		// Returns:
		//     A point on the perimeter of the collider that is closest to the specified position.
		public static Vector2 ClosestPoint(Vector2 position, Collider2D collider);
		//
		// Summary:
		//     Returns a point on the perimeter of all enabled colliders attached to the rigidbody
		//     that is closest to the specified position.
		//
		// Parameters:
		//   position:
		//     The position from which to find the closest point on the specified rigidbody.
		//
		//   rigidbody:
		//     The Rigidbody on which to find the closest specified position.
		//
		// Returns:
		//     A point on the perimeter of a Collider attached to the rigidbody that is closest
		//     to the specified position.
		public static Vector2 ClosestPoint(Vector2 position, Rigidbody2D rigidbody);
		//
		// Summary:
		//     Calculates the minimum distance between two colliders.
		//
		// Parameters:
		//   colliderA:
		//     A collider used to calculate the minimum distance against colliderB.
		//
		//   colliderB:
		//     A collider used to calculate the minimum distance against colliderA.
		//
		// Returns:
		//     The minimum distance between colliderA and colliderB.
		public static ColliderDistance2D Distance([Writable] Collider2D colliderA, [Writable] Collider2D colliderB);
		//
		// Summary:
		//     Retrieves all colliders in contact with the collider.
		//
		// Parameters:
		//   collider:
		//     The collider to retrieve contacts for.
		//
		//   colliders:
		//     An array of Collider2D used to receive the results.
		//
		// Returns:
		//     Returns the number of colliders placed in the colliders array.
		public static int GetContacts(Collider2D collider, Collider2D[] colliders);
		//
		// Summary:
		//     Retrieves all colliders in contact with the collider, with the results filtered
		//     by the ContactFilter2D.
		//
		// Parameters:
		//   collider:
		//     The collider to retrieve contacts for.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		//   colliders:
		//     An array of Collider2D used to receive the results.
		//
		// Returns:
		//     Returns the number of colliders placed in the colliders array.
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] colliders);
		//
		// Summary:
		//     Retrieves all contact points in contact with any of the collider(s) attached
		//     to this rigidbody.
		//
		// Parameters:
		//   rigidbody:
		//     The rigidbody to retrieve contacts for. All colliders attached to this rigidbody
		//     will be checked.
		//
		//   contacts:
		//     An array of ContactPoint2D used to receive the results.
		//
		// Returns:
		//     Returns the number of contacts placed in the contacts array.
		public static int GetContacts(Rigidbody2D rigidbody, ContactPoint2D[] contacts);
		public static int GetContacts(Rigidbody2D rigidbody, List<ContactPoint2D> contacts);
		//
		// Summary:
		//     Retrieves all contact points in contact with any of the collider(s) attached
		//     to this rigidbody, with the results filtered by the ContactFilter2D.
		//
		// Parameters:
		//   rigidbody:
		//     The rigidbody to retrieve contacts for. All colliders attached to this rigidbody
		//     will be checked.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		//   contacts:
		//     An array of ContactPoint2D used to receive the results.
		//
		// Returns:
		//     Returns the number of contacts placed in the contacts array.
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, ContactPoint2D[] contacts);
		//
		// Summary:
		//     Retrieves all colliders in contact with any of the collider(s) attached to this
		//     rigidbody.
		//
		// Parameters:
		//   rigidbody:
		//     The rigidbody to retrieve contacts for. All colliders attached to this rigidbody
		//     will be checked.
		//
		//   colliders:
		//     An array of Collider2D used to receive the results.
		//
		// Returns:
		//     Returns the number of colliders placed in the colliders array.
		public static int GetContacts(Rigidbody2D rigidbody, Collider2D[] colliders);
		public static int GetContacts(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, List<ContactPoint2D> contacts);
		public static int GetContacts(Collider2D collider, List<ContactPoint2D> contacts);
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<ContactPoint2D> contacts);
		public static int GetContacts(Collider2D collider, List<Collider2D> colliders);
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> contacts);
		public static int GetContacts(Rigidbody2D rigidbody, List<Collider2D> colliders);
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> colliders);
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> colliders);
		//
		// Summary:
		//     Retrieves all contact points in contact with the collider, with the results filtered
		//     by the ContactFilter2D.
		//
		// Parameters:
		//   collider:
		//     The collider to retrieve contacts for.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		//   contacts:
		//     An array of ContactPoint2D used to receive the results.
		//
		// Returns:
		//     Returns the number of contacts placed in the contacts array.
		public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, ContactPoint2D[] contacts);
		//
		// Summary:
		//     Retrieves all colliders in contact with any of the collider(s) attached to this
		//     rigidbody, with the results filtered by the ContactFilter2D.
		//
		// Parameters:
		//   rigidbody:
		//     The rigidbody to retrieve contacts for. All colliders attached to this rigidbody
		//     will be checked.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		//   colliders:
		//     An array of Collider2D used to receive the results.
		//
		// Returns:
		//     Returns the number of colliders placed in the colliders array.
		public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Collider2D[] colliders);
		//
		// Summary:
		//     Retrieves all contact points in for contacts between with the collider1 and collider2,
		//     with the results filtered by the ContactFilter2D.
		//
		// Parameters:
		//   collider1:
		//     The collider to check if it has contacts against collider2.
		//
		//   collider2:
		//     The collider to check if it has contacts against collider1.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		//   contacts:
		//     An array of ContactPoint2D used to receive the results.
		//
		// Returns:
		//     Returns the number of contacts placed in the contacts array.
		public static int GetContacts(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, ContactPoint2D[] contacts);
		//
		// Summary:
		//     Retrieves all contact points in contact with the collider.
		//
		// Parameters:
		//   collider:
		//     The collider to retrieve contacts for.
		//
		//   contacts:
		//     An array of ContactPoint2D used to receive the results.
		//
		// Returns:
		//     Returns the number of contacts placed in the contacts array.
		public static int GetContacts(Collider2D collider, ContactPoint2D[] contacts);
		//
		// Summary:
		//     Checks whether the collision detection system will ignore all collisionstriggers
		//     between collider1 and collider2/ or not.
		//
		// Parameters:
		//   collider1:
		//     The first collider to compare to collider2.
		//
		//   collider2:
		//     The second collider to compare to collider1.
		//
		// Returns:
		//     Whether the collision detection system will ignore all collisionstriggers between
		//     collider1 and collider2/ or not.
		[NativeMethod("GetIgnoreCollision_Binding")]
		[StaticAccessor("PhysicsScene2D", StaticAccessorType.DoubleColon)]
		public static bool GetIgnoreCollision([NotNull][Writable] Collider2D collider1, [NotNull][Writable] Collider2D collider2);
		//
		// Summary:
		//     Checks whether collisions between the specified layers be ignored or not.
		//
		// Parameters:
		//   layer1:
		//     ID of first layer.
		//
		//   layer2:
		//     ID of second layer.
		//
		// Returns:
		//     Whether collisions between the specified layers be ignored or not.
		public static bool GetIgnoreLayerCollision(int layer1, int layer2);
		//
		// Summary:
		//     Get the collision layer mask that indicates which layer(s) the specified layer
		//     can collide with.
		//
		// Parameters:
		//   layer:
		//     The layer to retrieve the collision layer mask for.
		//
		// Returns:
		//     A mask where each bit indicates a layer and whether it can collide with layer
		//     or not.
		public static int GetLayerCollisionMask(int layer);
		[ExcludeFromDocs]
		public static RaycastHit2D GetRayIntersection(Ray ray, float distance);
		[ExcludeFromDocs]
		public static RaycastHit2D GetRayIntersection(Ray ray);
		//
		// Summary:
		//     Cast a 3D ray against the colliders in the Scene returning the first collider
		//     along the ray.
		//
		// Parameters:
		//   ray:
		//     The 3D ray defining origin and direction to test.
		//
		//   distance:
		//     The maximum distance over which to cast the ray.
		//
		//   layerMask:
		//     Filter to detect colliders only on certain layers.
		//
		// Returns:
		//     The cast results returned.
		public static RaycastHit2D GetRayIntersection(Ray ray, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask);
		//
		// Summary:
		//     Cast a 3D ray against the colliders in the Scene returning all the colliders
		//     along the ray.
		//
		// Parameters:
		//   ray:
		//     The 3D ray defining origin and direction to test.
		//
		//   distance:
		//     The maximum distance over which to cast the ray.
		//
		//   layerMask:
		//     Filter to detect colliders only on certain layers.
		//
		// Returns:
		//     The cast results returned.
		[RequiredByNativeCode]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask);
		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance);
		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray);
		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results);
		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance);
		//
		// Summary:
		//     Cast a 3D ray against the colliders in the Scene returning the colliders along
		//     the ray.
		//
		// Parameters:
		//   ray:
		//     The 3D ray defining origin and direction to test.
		//
		//   distance:
		//     The maximum distance over which to cast the ray.
		//
		//   layerMask:
		//     Filter to detect colliders only on certain layers.
		//
		//   results:
		//     Array to receive results.
		//
		// Returns:
		//     The number of results returned.
		[RequiredByNativeCode]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask);
		[ExcludeFromDocs]
		public static void IgnoreCollision([Writable] Collider2D collider1, [Writable] Collider2D collider2);
		//
		// Summary:
		//     Makes the collision detection system ignore all collisionstriggers between collider1
		//     and collider2/.
		//
		// Parameters:
		//   collider1:
		//     The first collider to compare to collider2.
		//
		//   collider2:
		//     The second collider to compare to collider1.
		//
		//   ignore:
		//     Whether collisionstriggers between collider1 and collider2/ should be ignored
		//     or not.
		[NativeMethod("IgnoreCollision_Binding")]
		[StaticAccessor("PhysicsScene2D", StaticAccessorType.DoubleColon)]
		public static void IgnoreCollision([NotNull][Writable] Collider2D collider1, [NotNull][Writable] Collider2D collider2, [Internal.DefaultValue("true")] bool ignore);
		[ExcludeFromDocs]
		public static void IgnoreLayerCollision(int layer1, int layer2);
		//
		// Summary:
		//     Choose whether to detect or ignore collisions between a specified pair of layers.
		//
		// Parameters:
		//   layer1:
		//     ID of the first layer.
		//
		//   layer2:
		//     ID of the second layer.
		//
		//   ignore:
		//     Should collisions between these layers be ignored?
		public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore);
		//
		// Summary:
		//     Checks whether the passed colliders are in contact or not.
		//
		// Parameters:
		//   collider1:
		//     The collider to check if it is touching collider2.
		//
		//   collider2:
		//     The collider to check if it is touching collider1.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		// Returns:
		//     Whether collider1 is touching collider2 or not.
		public static bool IsTouching([Writable] Collider2D collider1, [Writable] Collider2D collider2, ContactFilter2D contactFilter);
		//
		// Summary:
		//     Checks whether the passed colliders are in contact or not.
		//
		// Parameters:
		//   collider:
		//     The collider to check if it is touching any other collider filtered by the contactFilter.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		// Returns:
		//     Whether the collider is touching any other collider filtered by the contactFilter
		//     or not.
		public static bool IsTouching([Writable] Collider2D collider, ContactFilter2D contactFilter);
		//
		// Summary:
		//     Checks whether the passed colliders are in contact or not.
		//
		// Parameters:
		//   collider1:
		//     The collider to check if it is touching collider2.
		//
		//   collider2:
		//     The collider to check if it is touching collider1.
		//
		// Returns:
		//     Whether collider1 is touching collider2 or not.
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		public static bool IsTouching([NotNull][Writable] Collider2D collider1, [NotNull][Writable] Collider2D collider2);
		//
		// Summary:
		//     Checks whether the collider is touching any colliders on the specified layerMask
		//     or not.
		//
		// Parameters:
		//   collider:
		//     The collider to check if it is touching colliders on the layerMask.
		//
		//   layerMask:
		//     Any colliders on any of these layers count as touching.
		//
		// Returns:
		//     Whether the collider is touching any colliders on the specified layerMask or
		//     not.
		[StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
		public static bool IsTouchingLayers([NotNull][Writable] Collider2D collider, [Internal.DefaultValue("Physics2D.AllLayers")] int layerMask);
		[ExcludeFromDocs]
		public static bool IsTouchingLayers([Writable] Collider2D collider);
		[ExcludeFromDocs]
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end);
		//
		// Summary:
		//     Casts a line segment against colliders in the Scene with results filtered by
		//     ContactFilter2D.
		//
		// Parameters:
		//   start:
		//     The start point of the line in world space.
		//
		//   end:
		//     The end point of the line in world space.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		//   results:
		//     The array to receive results. The size of the array determines the maximum number
		//     of results that can be returned.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, RaycastHit2D[] results);
		[ExcludeFromDocs]
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth);
		//
		// Summary:
		//     Casts a line segment against colliders in the Scene.
		//
		// Parameters:
		//   start:
		//     The start point of the line in world space.
		//
		//   end:
		//     The end point of the line in world space.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The cast results returned.
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		public static int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, List<RaycastHit2D> results);
		[ExcludeFromDocs]
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask);
		[ExcludeFromDocs]
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end);
		//
		// Summary:
		//     Casts a line against colliders in the Scene.
		//
		// Parameters:
		//   start:
		//     The start point of the line in world space.
		//
		//   end:
		//     The end point of the line in world space.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The cast results returned.
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask);
		//
		// Summary:
		//     Casts a line against colliders in the Scene.
		//
		// Parameters:
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		//   start:
		//     The start point of the line in world space.
		//
		//   end:
		//     The end point of the line in world space.
		//
		//   results:
		//     Returned array of objects that intersect the line.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask);
		[ExcludeFromDocs]
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results);
		[ExcludeFromDocs]
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask, float minDepth);
		//
		// Summary:
		//     Checks if a collider falls within a rectangular area.
		//
		// Parameters:
		//   pointA:
		//     One corner of the rectangle.
		//
		//   pointB:
		//     Diagonally opposite the point A corner of the rectangle.
		//
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
		public static int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Collider2D[] results);
		//
		// Summary:
		//     Checks if a collider falls within a rectangular area.
		//
		// Parameters:
		//   pointA:
		//     One corner of the rectangle.
		//
		//   pointB:
		//     Diagonally opposite the point A corner of the rectangle.
		//
		//   layerMask:
		//     Filter to check objects only on specific layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The collider overlapping the area.
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask);
		public static int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, List<Collider2D> results);
		[ExcludeFromDocs]
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB);
		//
		// Summary:
		//     Get a list of all colliders that fall within a rectangular area.
		//
		// Parameters:
		//   pointA:
		//     One corner of the rectangle.
		//
		//   pointB:
		//     Diagonally opposite the point A corner of the rectangle.
		//
		//   layerMask:
		//     Filter to check objects only on specific layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The cast results returned.
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask);
		[ExcludeFromDocs]
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask, float minDepth);
		//
		// Summary:
		//     Get a list of all colliders that fall within a specified area.
		//
		// Parameters:
		//   pointA:
		//     One corner of the rectangle.
		//
		//   pointB:
		//     Diagonally opposite the point A corner of the rectangle.
		//
		//   results:
		//     Array to receive results.
		//
		//   layerMask:
		//     Filter to check objects only on specified layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results);
		[ExcludeFromDocs]
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle);
		//
		// Summary:
		//     Checks if a collider falls within a box area.
		//
		// Parameters:
		//   point:
		//     The center of the box.
		//
		//   size:
		//     The size of the box.
		//
		//   angle:
		//     The angle of the box.
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
		// Returns:
		//     The collider overlapping the box.
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		public static int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, List<Collider2D> results);
		//
		// Summary:
		//     Checks if a collider falls within a box area.
		//
		// Parameters:
		//   point:
		//     The center of the box.
		//
		//   size:
		//     The size of the box.
		//
		//   angle:
		//     The angle of the box.
		//
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
		public static int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Collider2D[] results);
		[ExcludeFromDocs]
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask);
		[ExcludeFromDocs]
		public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth);
		//
		// Summary:
		//     Get a list of all colliders that fall within a box area.
		//
		// Parameters:
		//   point:
		//     The center of the box.
		//
		//   size:
		//     The size of the box.
		//
		//   angle:
		//     The angle of the box.
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
		// Returns:
		//     The cast results returned.
		public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle);
		//
		// Summary:
		//     Get a list of all colliders that fall within a box area.
		//
		// Parameters:
		//   point:
		//     The center of the box.
		//
		//   size:
		//     The size of the box.
		//
		//   angle:
		//     The angle of the box.
		//
		//   results:
		//     Array to receive results.
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
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask);
		[ExcludeFromDocs]
		public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results);
		public static int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, List<Collider2D> results);
		[ExcludeFromDocs]
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle);
		[ExcludeFromDocs]
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask);
		//
		// Summary:
		//     Checks if a collider falls within a capsule area.
		//
		// Parameters:
		//   point:
		//     The center of the capsule.
		//
		//   size:
		//     The size of the capsule.
		//
		//   direction:
		//     The direction of the capsule.
		//
		//   angle:
		//     The angle of the capsule.
		//
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
		public static int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Collider2D[] results);
		//
		// Summary:
		//     Checks if a collider falls within a capsule area.
		//
		// Parameters:
		//   point:
		//     The center of the capsule.
		//
		//   size:
		//     The size of the capsule.
		//
		//   direction:
		//     The direction of the capsule.
		//
		//   angle:
		//     The angle of the capsule.
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
		// Returns:
		//     The collider overlapping the capsule.
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth);
		//
		// Summary:
		//     Get a list of all colliders that fall within a capsule area.
		//
		// Parameters:
		//   point:
		//     The center of the capsule.
		//
		//   size:
		//     The size of the capsule.
		//
		//   direction:
		//     The direction of the capsule.
		//
		//   angle:
		//     The angle of the capsule.
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
		// Returns:
		//     The cast results returned.
		public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle);
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results);
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, int layerMask);
		[ExcludeFromDocs]
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, int layerMask, float minDepth);
		//
		// Summary:
		//     Get a list of all colliders that fall within a capsule area.
		//
		// Parameters:
		//   point:
		//     The center of the capsule.
		//
		//   size:
		//     The size of the capsule.
		//
		//   direction:
		//     The direction of the capsule.
		//
		//   angle:
		//     The angle of the capsule.
		//
		//   results:
		//     Array to receive results.
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
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		//
		// Summary:
		//     Checks if a collider is within a circular area.
		//
		// Parameters:
		//   point:
		//     Centre of the circle.
		//
		//   radius:
		//     The radius of the circle.
		//
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
		public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results);
		public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results);
		[ExcludeFromDocs]
		public static Collider2D OverlapCircle(Vector2 point, float radius);
		[ExcludeFromDocs]
		public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask);
		//
		// Summary:
		//     Checks if a collider falls within a circular area.
		//
		// Parameters:
		//   point:
		//     Centre of the circle.
		//
		//   radius:
		//     The radius of the circle.
		//
		//   layerMask:
		//     Filter to check objects only on specific layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The collider overlapping the circle.
		public static Collider2D OverlapCircle(Vector2 point, float radius, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius);
		//
		// Summary:
		//     Get a list of all colliders that fall within a circular area.
		//
		// Parameters:
		//   point:
		//     The center of the circle.
		//
		//   radius:
		//     The radius of the circle.
		//
		//   layerMask:
		//     Filter to check objects only on specified layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The cast results.
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results);
		//
		// Summary:
		//     Get a list of all colliders that fall within a circular area.
		//
		// Parameters:
		//   point:
		//     The center of the circle.
		//
		//   radius:
		//     The radius of the circle.
		//
		//   results:
		//     Array to receive results.
		//
		//   layerMask:
		//     Filter to check objects only on specific layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask);
		public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results);
		//
		// Summary:
		//     Gets a list of all Colliders that overlap the given collider.
		//
		// Parameters:
		//   collider:
		//     The collider that defines the area used to query for other collider overlaps.
		//
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
		public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] results);
		public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, List<Collider2D> results);
		[ExcludeFromDocs]
		public static Collider2D OverlapPoint(Vector2 point);
		//
		// Summary:
		//     Checks if a collider overlaps a point in world space.
		//
		// Parameters:
		//   point:
		//     A point in world space.
		//
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
		public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Collider2D[] results);
		//
		// Summary:
		//     Checks if a collider overlaps a point in space.
		//
		// Parameters:
		//   point:
		//     A point in world space.
		//
		//   layerMask:
		//     Filter to check objects only on specific layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The collider overlapping the point.
		public static Collider2D OverlapPoint(Vector2 point, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static Collider2D OverlapPoint(Vector2 point, int layerMask);
		//
		// Summary:
		//     Get a list of all colliders that overlap a point in space.
		//
		// Parameters:
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		//   point:
		//     A point in space.
		//
		//   layerMask:
		//     Filter to check objects only on specific layers.
		//
		// Returns:
		//     The cast results returned.
		public static Collider2D[] OverlapPointAll(Vector2 point, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapPointAll(Vector2 point, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapPointAll(Vector2 point, int layerMask);
		[ExcludeFromDocs]
		public static Collider2D[] OverlapPointAll(Vector2 point);
		//
		// Summary:
		//     Get a list of all colliders that overlap a point in space.
		//
		// Parameters:
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		//   point:
		//     A point in space.
		//
		//   results:
		//     Array to receive results.
		//
		//   layerMask:
		//     Filter to check objects only on specific layers.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask);
		[ExcludeFromDocs]
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results);
		//
		// Summary:
		//     Casts a ray against colliders in the Scene.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the ray originates.
		//
		//   direction:
		//     A vector representing the direction of the ray.
		//
		//   contactFilter:
		//     The contact filter used to filter the results differently, such as by layer mask,
		//     Z depth, or normal angle.
		//
		//   results:
		//     The array to receive results. The size of the array determines the maximum number
		//     of results that can be returned.
		//
		//   distance:
		//     The maximum distance over which to cast the ray.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [Internal.DefaultValue("Mathf.Infinity")] float distance);
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Internal.DefaultValue("Mathf.Infinity")] float distance = float.PositiveInfinity);
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction);
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance);
		[ExcludeFromDocs]
		public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
		[ExcludeFromDocs]
		[RequiredByNativeCode]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask);
		//
		// Summary:
		//     Casts a ray against colliders in the Scene.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the ray originates.
		//
		//   direction:
		//     A vector representing the direction of the ray.
		//
		//   distance:
		//     The maximum distance over which to cast the ray.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The cast results returned.
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth);
		//
		// Summary:
		//     Casts a ray against colliders in the Scene, returning all colliders that contact
		//     with it.
		//
		// Parameters:
		//   origin:
		//     The point in 2D space where the ray originates.
		//
		//   direction:
		//     A vector representing the direction of the ray.
		//
		//   distance:
		//     The maximum distance over which to cast the ray.
		//
		//   layerMask:
		//     Filter to detect Colliders only on certain layers.
		//
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		// Returns:
		//     The cast results returned.
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance);
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask);
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction);
		//
		// Summary:
		//     Casts a ray into the Scene.
		//
		// Parameters:
		//   minDepth:
		//     Only include objects with a Z coordinate (depth) greater than or equal to this
		//     value.
		//
		//   maxDepth:
		//     Only include objects with a Z coordinate (depth) less than or equal to this value.
		//
		//   origin:
		//     The point in 2D space where the ray originates.
		//
		//   direction:
		//     A vector representing the direction of the ray.
		//
		//   results:
		//     Array to receive results.
		//
		//   distance:
		//     The maximum distance over which to cast the ray.
		//
		//   layerMask:
		//     Filter to check objects only on specific layers.
		//
		// Returns:
		//     Returns the number of results placed in the results array.
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, [Internal.DefaultValue("Mathf.Infinity")] float distance, [Internal.DefaultValue("DefaultRaycastLayers")] int layerMask, [Internal.DefaultValue("-Mathf.Infinity")] float minDepth, [Internal.DefaultValue("Mathf.Infinity")] float maxDepth);
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance);
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results);
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
		//
		// Summary:
		//     Set the collision layer mask that indicates which layer(s) the specified layer
		//     can collide with.
		//
		// Parameters:
		//   layer:
		//     The layer to set the collision layer mask for.
		//
		//   layerMask:
		//     A mask where each bit indicates a layer and whether it can collide with layer
		//     or not.
		public static void SetLayerCollisionMask(int layer, int layerMask);
		//
		// Summary:
		//     Simulate physics in the Scene.
		//
		// Parameters:
		//   step:
		//     The time to advance physics by.
		//
		// Returns:
		//     Whether the simulation was run or not. Running the simulation during physics
		//     callbacks will always fail.
		public static bool Simulate(float step);
		//
		// Summary:
		//     Synchronizes.
		public static void SyncTransforms();
		*/
	}
}