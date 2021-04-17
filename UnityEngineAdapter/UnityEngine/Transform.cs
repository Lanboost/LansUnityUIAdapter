using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine
{
	public class Transform : Component, IEnumerable
	{
		protected Vector3 _parentPosition;
		protected Vector3 _localPosition;


		public static Transform Create(GameObject gameObject)
		{
			var t = new Transform();
			t._gameObject = gameObject;

			t.rotation = Quaternion.identity;
			return t;
		}

		List<Transform> children = new List<Transform>();
		private Transform _parent;
		protected Transform() {
			
		}

		//
		// Summary:
		//     Position of the transform relative to the parent transform.
		public Vector3 localPosition { get => new Vector3(0,0,0);
			set {
				var re = this.GetComponent<RectTransform>();

				re.offsetMin += new Vector2(value.x, value.y);
				re.offsetMax += new Vector2(value.x, value.y);
			}
		}
		//
		// Summary:
		//     The rotation as Euler angles in degrees.
		public Vector3 eulerAngles { get; set; }
		//
		// Summary:
		//     The rotation as Euler angles in degrees relative to the parent transform's rotation.
		public Vector3 localEulerAngles { get; set; }
		//
		// Summary:
		//     The red axis of the transform in world space.
		public Vector3 right { get; set; }
		//
		// Summary:
		//     The green axis of the transform in world space.
		public Vector3 up { get; set; }
		//
		// Summary:
		//     Returns a normalized vector representing the blue axis of the transform in world
		//     space.
		public Vector3 forward { get; set; }
		//
		// Summary:
		//     A Quaternion that stores the rotation of the Transform in world space.
		public Quaternion rotation { get; set; }
		//
		// Summary:
		//     The world space position of the Transform.
		public Vector3 position {
			get
			{
				return _parentPosition + _localPosition;
			}
			set
			{
				_localPosition = value - _parentPosition;
			}
		}
		//
		// Summary:
		//     The rotation of the transform relative to the transform rotation of the parent.
		public Quaternion localRotation { get; set; }
		//
		// Summary:
		//     The parent of the transform.
		public Transform parent {
			get
			{
				return _parent;
			}
			set
			{
				if(_parent != null)
				{
					_parent.children.Remove(this);
				}

				foreach (var m in this.gameObject.GetEnabledMonoBehaviours())
				{
					//TODO
					Helper.Call(m,"OnBeforeTransformParentChanged");
				}

				this._parent = value;
				this._parent.children.Add(this);

				if(this is RectTransform)
				{
					var selfRect = (RectTransform)this;
					var parentRect = (RectTransform)value;

					selfRect.UpdateParent(parentRect._selfRect);
				}
				else
				{
					
				}
				this._localPosition = this._parentPosition + this._localPosition - this._parent.position;
				this._parentPosition = this._parent.position;

				foreach (var m in this.gameObject.GetEnabledMonoBehaviours())
				{
					Helper.Call(m, "OnTransformParentChanged");
				}
			}
		}

		//
		// Summary:
		//     Matrix that transforms a point from world space into local space (Read Only).
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				var t = this.GetComponent<RectTransform>();
				var p = -t._worldRect.position+t._rect.position;
				return new Matrix4x4(
					new Vector4(1, 0, 0, 0), 
					new Vector4(0, 1, 0, 0), 
					new Vector4(0, 0, 1, 0), 
					new Vector4(p.x, p.y, 0, 1));
			}
		}
		//
		// Summary:
		//     Matrix that transforms a point from local space into world space (Read Only).
		public Matrix4x4 localToWorldMatrix { get; }
		//
		// Summary:
		//     Returns the topmost transform in the hierarchy.
		public Transform root { get; }
		//
		// Summary:
		//     The number of children the parent Transform has.
		public int childCount { get => this.children.Count; }
		//
		// Summary:
		//     The global scale of the object (Read Only).
		public Vector3 lossyScale { get; }
		//
		// Summary:
		//     Has the transform changed since the last time the flag was set to 'false'?
		[NativeProperty("HasChangedDeprecated")]
		public bool hasChanged { get; set; }
		//
		// Summary:
		//     The scale of the transform relative to the GameObjects parent.
		public Vector3 localScale { get; set; }
		//
		// Summary:
		//     The transform capacity of the transform's hierarchy data structure.
		public int hierarchyCapacity { get; set; }
		//
		// Summary:
		//     The number of transforms in the transform's hierarchy data structure.
		public int hierarchyCount { get; }

		//
		// Summary:
		//     Unparents all children.
		[FreeFunction("DetachChildren", HasExplicitThis = true)]
		public void DetachChildren() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Finds a child by n and returns it.
		//
		// Parameters:
		//   n:
		//     Name of child to be found.
		//
		// Returns:
		//     The returned child transform or null if no child is found.
		public Transform Find(string n) { throw new System.NotImplementedException(); }
		[Obsolete("FindChild has been deprecated. Use Find instead (UnityUpgradable) -> Find([mscorlib] System.String)", false)]
		public Transform FindChild(string n) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Returns a transform child by index.
		//
		// Parameters:
		//   index:
		//     Index of the child transform to return. Must be smaller than Transform.childCount.
		//
		// Returns:
		//     Transform child by index.
		[FreeFunction("GetChild", HasExplicitThis = true)]
		[NativeThrows]
		public Transform GetChild(int index) {
			return children[index];
		}
		[NativeMethod("GetChildrenCount")]
		[Obsolete("warning use Transform.childCount instead (UnityUpgradable) -> Transform.childCount", false)]
		public int GetChildCount() {
			return this.childCount;
		}
		public IEnumerator GetEnumerator() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Gets the sibling index.
		public int GetSiblingIndex() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms a direction from world space to local space. The opposite of Transform.TransformDirection.
		//
		// Parameters:
		//   direction:
		public Vector3 InverseTransformDirection(Vector3 direction) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms the direction x, y, z from world space to local space. The opposite
		//     of Transform.TransformDirection.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   z:
		public Vector3 InverseTransformDirection(float x, float y, float z) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms the position x, y, z from world space to local space. The opposite
		//     of Transform.TransformPoint.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   z:
		public Vector3 InverseTransformPoint(float x, float y, float z) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms position from world space to local space.
		//
		// Parameters:
		//   position:
		public Vector3 InverseTransformPoint(Vector3 position) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms a vector from world space to local space. The opposite of Transform.TransformVector.
		//
		// Parameters:
		//   vector:
		public Vector3 InverseTransformVector(Vector3 vector) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms the vector x, y, z from world space to local space. The opposite of
		//     Transform.TransformVector.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   z:
		public Vector3 InverseTransformVector(float x, float y, float z) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Is this transform a child of parent?
		//
		// Parameters:
		//   parent:
		[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = true)]
		public bool IsChildOf([NotNull] Transform parent) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Rotates the transform so the forward vector points at target's current position.
		//
		// Parameters:
		//   target:
		//     Object to point towards.
		//
		//   worldUp:
		//     Vector specifying the upward direction.
		public void LookAt(Transform target, [DefaultValue("Vector3.up")] Vector3 worldUp) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Rotates the transform so the forward vector points at worldPosition.
		//
		// Parameters:
		//   worldPosition:
		//     Point to look at.
		//
		//   worldUp:
		//     Vector specifying the upward direction.
		public void LookAt(Vector3 worldPosition, [DefaultValue("Vector3.up")] Vector3 worldUp) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Rotates the transform so the forward vector points at worldPosition.
		//
		// Parameters:
		//   worldPosition:
		//     Point to look at.
		//
		//   worldUp:
		//     Vector specifying the upward direction.
		public void LookAt(Vector3 worldPosition) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Rotates the transform so the forward vector points at target's current position.
		//
		// Parameters:
		//   target:
		//     Object to point towards.
		//
		//   worldUp:
		//     Vector specifying the upward direction.
		public void LookAt(Transform target) { throw new System.NotImplementedException(); }
		public void Rotate(float xAngle, float yAngle, float zAngle) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Applies a rotation of eulerAngles.z degrees around the z-axis, eulerAngles.x
		//     degrees around the x-axis, and eulerAngles.y degrees around the y-axis (in that
		//     order).
		//
		// Parameters:
		//   eulers:
		//     The rotation to apply.
		//
		//   relativeTo:
		//     Determines whether to rotate the GameObject either locally to the GameObject
		//     or relative to the Scene in world space.
		public void Rotate(Vector3 eulers, [DefaultValue("Space.Self")] Space relativeTo) { throw new System.NotImplementedException(); }
		public void Rotate(Vector3 eulers) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     The implementation of this method applies a rotation of zAngle degrees around
		//     the z axis, xAngle degrees around the x axis, and yAngle degrees around the y
		//     axis (in that order).
		//
		// Parameters:
		//   relativeTo:
		//     Determines whether to rotate the GameObject either locally to the GameObject
		//     or relative to the Scene in world space.
		//
		//   xAngle:
		//     Degrees to rotate the GameObject around the X axis.
		//
		//   yAngle:
		//     Degrees to rotate the GameObject around the Y axis.
		//
		//   zAngle:
		//     Degrees to rotate the GameObject around the Z axis.
		public void Rotate(float xAngle, float yAngle, float zAngle, [DefaultValue("Space.Self")] Space relativeTo) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Rotates the object around the given axis by the number of degrees defined by
		//     the given angle.
		//
		// Parameters:
		//   angle:
		//     The degrees of rotation to apply.
		//
		//   axis:
		//     The axis to apply rotation to.
		//
		//   relativeTo:
		//     Determines whether to rotate the GameObject either locally to the GameObject
		//     or relative to the Scene in world space.
		public void Rotate(Vector3 axis, float angle, [DefaultValue("Space.Self")] Space relativeTo) { throw new System.NotImplementedException(); }
		public void Rotate(Vector3 axis, float angle) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Rotates the transform about axis passing through point in world coordinates by
		//     angle degrees.
		//
		// Parameters:
		//   point:
		//
		//   axis:
		//
		//   angle:
		public void RotateAround(Vector3 point, Vector3 axis, float angle) { throw new System.NotImplementedException(); }
		//
		// Parameters:
		//   axis:
		//
		//   angle:
		[Obsolete("warning use Transform.Rotate instead.")]
		public void RotateAround(Vector3 axis, float angle) { throw new System.NotImplementedException(); }
		[Obsolete("warning use Transform.Rotate instead.")]
		public void RotateAroundLocal(Vector3 axis, float angle) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Move the transform to the start of the local transform list.
		public void SetAsFirstSibling() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Move the transform to the end of the local transform list.
		public void SetAsLastSibling() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Set the parent of the transform.
		//
		// Parameters:
		//   parent:
		//     The parent Transform to use.
		//
		//   worldPositionStays:
		//     If true, the parent-relative position, scale and rotation are modified such that
		//     the object keeps the same world space position, rotation and scale as before.
		//
		//   p:
		public void SetParent(Transform p) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Set the parent of the transform.
		//
		// Parameters:
		//   parent:
		//     The parent Transform to use.
		//
		//   worldPositionStays:
		//     If true, the parent-relative position, scale and rotation are modified such that
		//     the object keeps the same world space position, rotation and scale as before.
		//
		//   p:
		[FreeFunction("SetParent", HasExplicitThis = true)]
		public void SetParent(Transform parent, bool worldPositionStays) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the world space position and rotation of the Transform component.
		//
		// Parameters:
		//   position:
		//
		//   rotation:
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Sets the sibling index.
		//
		// Parameters:
		//   index:
		//     Index to set.
		public void SetSiblingIndex(int index) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms direction x, y, z from local space to world space.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   z:
		public Vector3 TransformDirection(float x, float y, float z) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms direction from local space to world space.
		//
		// Parameters:
		//   direction:
		public Vector3 TransformDirection(Vector3 direction) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms the position x, y, z from local space to world space.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   z:
		public Vector3 TransformPoint(float x, float y, float z) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms position from local space to world space.
		//
		// Parameters:
		//   position:
		public Vector3 TransformPoint(Vector3 position) {
			return this.position + position;
		}
		//
		// Summary:
		//     Transforms vector x, y, z from local space to world space.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   z:
		public Vector3 TransformVector(float x, float y, float z) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Transforms vector from local space to world space.
		//
		// Parameters:
		//   vector:
		public Vector3 TransformVector(Vector3 vector) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Moves the transform by x along the x axis, y along the y axis, and z along the
		//     z axis.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   z:
		//
		//   relativeTo:
		public void Translate(float x, float y, float z) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Moves the transform by x along the x axis, y along the y axis, and z along the
		//     z axis.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   z:
		//
		//   relativeTo:
		public void Translate(float x, float y, float z, [DefaultValue("Space.Self")] Space relativeTo) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Moves the transform in the direction and distance of translation.
		//
		// Parameters:
		//   translation:
		//
		//   relativeTo:
		public void Translate(Vector3 translation) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Moves the transform in the direction and distance of translation.
		//
		// Parameters:
		//   translation:
		//
		//   relativeTo:
		public void Translate(Vector3 translation, [DefaultValue("Space.Self")] Space relativeTo) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Moves the transform by x along the x axis, y along the y axis, and z along the
		//     z axis.
		//
		// Parameters:
		//   x:
		//
		//   y:
		//
		//   z:
		//
		//   relativeTo:
		public void Translate(float x, float y, float z, Transform relativeTo) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Moves the transform in the direction and distance of translation.
		//
		// Parameters:
		//   translation:
		//
		//   relativeTo:
		public void Translate(Vector3 translation, Transform relativeTo) { throw new System.NotImplementedException(); }
	}
}