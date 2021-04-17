

using UnityEngine;

namespace UnityEngine
{
	public sealed class RectTransform : Transform
	{
		internal Rect _parentRect;
		internal Rect _selfRect;
		internal Rect _rect;
		internal Rect _worldRect;

		internal Vector2 _anchorMin;
		internal Vector2 _anchorMax;
		internal Vector2 _offsetMin;
		internal Vector2 _offsetMax;
		internal Vector2 _pivot;

		public RectTransform()
		{

		}

		internal void Init(Rect parentRect)
		{
			this._parentRect = parentRect;
			_pivot = new Vector2(0.5f, 0.5f);
			_anchorMin = new Vector2(0, 0);
			_anchorMax = new Vector2(1, 1);
			_offsetMin = new Vector2(0, 0);
			_offsetMax = new Vector2(1, 1);

			Recalculate();
			//this._gameObject = gameObject;

			//this.rotation = Quaternion.identity;
			//UpdateChildren(_selfRect);
		}

		internal void Init(Vector2 size)
		{
			this._parentRect = new Rect(-size.x / 2, -size.y / 2, size.x, size.y);
			_pivot = new Vector2(0.5f, 0.5f);
			_anchorMin = new Vector2(0, 0);
			_anchorMax = new Vector2(1, 1);
			_offsetMin = new Vector2(0, 0);
			_offsetMax = new Vector2(0, 0);
			Recalculate();
			//this._gameObject = gameObject;

			//this.rotation = Quaternion.identity;
			
		}

		internal void Init(RectTransform v)
		{
			var prect = v.transform.parent.GetComponent<RectTransform>().rect;
			this._parentRect = new Rect(-prect.width / 2, -prect.height / 2, prect.width, prect.height);
			_pivot = v.pivot;
			_anchorMin = v.anchorMin;
			_anchorMax = v.anchorMax;
			_offsetMin = v.offsetMin;
			_offsetMax = v.offsetMax;
			Recalculate();
		}

		//
		// Summary:
		//     The position of the pivot of this RectTransform relative to the anchor reference
		//     point.
		public Vector2 anchoredPosition
		{
			get
			{
				/*var p1 = new Vector2(_parentRect.xMin, _parentRect.yMin) + _parentRect.size * ((_anchorMax - _anchorMin) / 2 + _anchorMin);
				var p2 = new Vector2(_selfRect.xMin, _selfRect.yMin) + _selfRect.size * _pivot;
				return p2 - p1;*/
				return this._offsetMin + (this._offsetMax - this._offsetMin) * pivot;
			}
			set
			{
				var diff = value - anchoredPosition;
				this._offsetMin += diff;
				this._offsetMax += diff;
				Recalculate();
			}
		}
		//
		// Summary:
		//     The offset of the upper right corner of the rectangle relative to the upper right
		//     anchor.
		public Vector2 offsetMax
		{
			get => _offsetMax;
			set
			{
				_offsetMax = value;
				Recalculate();
			}
		}
		//
		// Summary:
		//     The offset of the lower left corner of the rectangle relative to the lower left
		//     anchor.
		public Vector2 offsetMin
		{
			get => _offsetMin;
			set
			{
				_offsetMin = value;
				Recalculate();
			}
		}
		//
		// Summary:
		//     The 3D position of the pivot of this RectTransform relative to the anchor reference
		//     point.
		public Vector3 anchoredPosition3D { get; set; }
		//
		// Summary:
		//     The calculated rectangle in the local space of the Transform.
		public Rect rect
		{
			get => this._rect;
		}
		//
		// Summary:
		//     The normalized position in the parent RectTransform that the lower left corner
		//     is anchored to.
		public Vector2 anchorMin
		{
			get => _anchorMin;
			set
			{
				var corrected = (Vector2)Vector3.Min(new Vector3(1, 1, 0), Vector3.Max(new Vector3(0, 0, 0), value));

				_anchorMin = corrected;
				Recalculate();
			}
		}
		//
		// Summary:
		//     The normalized position in the parent RectTransform that the upper right corner
		//     is anchored to.
		public Vector2 anchorMax
		{
			get => _anchorMax;
			set
			{
				var corrected = (Vector2)Vector3.Min(new Vector3(1, 1, 0), Vector3.Max(new Vector3(0, 0, 0), value));

				_anchorMax = corrected;
				Recalculate();
			}
		}
		//
		// Summary:
		//     The normalized position in this RectTransform that it rotates around.
		public Vector2 pivot
		{
			get => _pivot;
			set
			{
				var pivotDiff = value - _pivot;
				var sDelta = sizeDelta;
				var diff = sDelta * pivotDiff;
				_offsetMin -= diff;
				_offsetMax -= diff;

				_pivot = value;
				Recalculate();
			}
		}
		//
		// Summary:
		//     The size of this RectTransform relative to the distances between the anchors.
		public Vector2 sizeDelta
		{
			get
			{
				return _offsetMax - _offsetMin;
			}
			set
			{
				if (0 == 1)
				{
					var currentDelta = sizeDelta;
					var deltaSize = value - currentDelta;

					_offsetMax = new Vector2(_offsetMax.x + deltaSize.x, _offsetMax.y);
					_offsetMin = new Vector2(_offsetMin.x, _offsetMin.y - deltaSize.y);
					Recalculate();
				}
				else
				{
					var currentDelta = sizeDelta;
					var deltaSize = value - currentDelta;
					_offsetMax += new Vector2(-deltaSize.x * (pivot.x - 1), -deltaSize.y * (pivot.y - 1));
					_offsetMin += new Vector2(-deltaSize.x * pivot.x, -deltaSize.y * pivot.y);
					Recalculate();
				}
			}
		}

		public static event ReapplyDrivenProperties reapplyDrivenProperties;

		//
		// Summary:
		//     Force the recalculation of RectTransforms internal data.

		internal void Recalculate()
		{
			
				var prev = this._worldRect;

				//recalculate
				{
					float x1 = this._parentRect.xMin + (_anchorMin.x * this._parentRect.width) + this._offsetMin.x;
					float y1 = this._parentRect.yMin + (_anchorMin.y * this._parentRect.height) + this._offsetMin.y;
					float x2 = this._parentRect.xMax + ((_anchorMax.x - 1) * this._parentRect.width) + this._offsetMax.x;
					float y2 = this._parentRect.yMax + ((_anchorMax.y - 1) * this._parentRect.height) + this._offsetMax.y;
					float width = x2 - x1;
					float height = y2 - y1;

					this._selfRect = new Rect(x1, y1, width, height);
					//Debug.Log("MyRect _selfRect:" + this._selfRect);
					//Debug.Log("MyRect anchoredPosition:" + this.anchoredPosition);
				}
				{
					float x1 = (_anchorMin.x * this._parentRect.width);
					float y1 = (_anchorMin.y * this._parentRect.height);
					float x2 = (_anchorMax.x * this._parentRect.width);
					float y2 = (_anchorMax.y * this._parentRect.height);
					float width = x2 - x1;
					//Debug.Log("Width is" + width);
					float height = y2 - y1;

					//this._rect = new Rect(new Vector2(-width / 2, -height / 2) - anchoredPosition, this._selfRect.size);
					this._rect = new Rect(new Vector2(-width * pivot.x + this._offsetMin.x, -height * pivot.y + this._offsetMin.y) - anchoredPosition, this._selfRect.size);
				}
				Vector3 position;
				Vector3 endPosition;
				{
					var offsetx = _parentRect.x + _parentRect.width * _anchorMin.x;
					var offsety = _parentRect.y + _parentRect.height * _anchorMin.y;
					var offset = new Vector2(offsetx, offsety);
					position = offset + _offsetMin;
				}
				{
					var offsetx = _parentRect.x + _parentRect.width * _anchorMax.x;
					var offsety = _parentRect.y + _parentRect.height * _anchorMax.y;
					var offset = new Vector2(offsetx, offsety);
					endPosition = offset + _offsetMax;
				}
				_worldRect = new Rect(position, endPosition - position);

				//Debug.Log("MyRect _rect:" + this._rect);
				UpdateChildren(prev);
			
		}

		internal void UpdateParent(Rect rect)
		{
			if (this.GetComponent<Canvas>() == null)
			{
				this._parentRect = rect;
			}
			Recalculate();
		}

		internal void UpdateChildren(Rect rect)
		{
			if (this._worldRect != rect)
			{
				foreach(var m in this.gameObject.GetEnabledMonoBehaviours())
				{
					Helper.Call(m, "OnRectTransformDimensionsChange");
				}


				for (int i = 0; i < this.childCount; i++)
				{
					var child = this.GetChild(i);
					var t = child.GetComponent<RectTransform>();

					t.UpdateParent(_worldRect);
				}
			}
		}

		public void ForceUpdateRectTransforms()
		{
		}
		//
		// Summary:
		//     Get the corners of the calculated rectangle in the local space of its Transform.
		//
		// Parameters:
		//   fourCornersArray:
		//     The array that corners are filled into.
		public void GetLocalCorners(Vector3[] fourCornersArray) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get the corners of the calculated rectangle in world space.
		//
		// Parameters:
		//   fourCornersArray:
		//     The array that corners are filled into.
		public void GetWorldCorners(Vector3[] fourCornersArray)
		{
			fourCornersArray[0] = _worldRect.position;
			fourCornersArray[2] = _worldRect.position + _worldRect.size;
			fourCornersArray[1] = new Vector2(fourCornersArray[0].x, fourCornersArray[2].y);
			fourCornersArray[3] = new Vector2(fourCornersArray[2].x, fourCornersArray[0].y);
		}

		public void SetInsetAndSizeFromParentEdge(Edge edge, float inset, float size) { throw new System.NotImplementedException(); }
		public void SetSizeWithCurrentAnchors(UnityEngine.RectTransform.Axis axis, float size)
		{
			if (axis == UnityEngine.RectTransform.Axis.Horizontal)
			{
				var width = _parentRect.width * (_anchorMax.x - _anchorMin.x);

				_offsetMin = new Vector2(width * pivot.x - size * pivot.x + anchoredPosition.x, _offsetMin.y);
				_offsetMax = new Vector2(_offsetMin.x - width + size, _offsetMax.y);
			}
			else if (axis == UnityEngine.RectTransform.Axis.Vertical)
			{
				var height = _parentRect.height * (_anchorMax.y - _anchorMin.y);

				_offsetMin = new Vector2(_offsetMin.x, height * pivot.y - size * pivot.y + anchoredPosition.y);
				_offsetMax = new Vector2(_offsetMax.x, _offsetMin.y - height + size);
			}
			Recalculate();
		}

		//
		// Summary:
		//     Enum used to specify one edge of a rectangle.
		public enum Edge
		{
			//
			// Summary:
			//     The left edge.
			Left = 0,
			//
			// Summary:
			//     The right edge.
			Right = 1,
			//
			// Summary:
			//     The top edge.
			Top = 2,
			//
			// Summary:
			//     The bottom edge.
			Bottom = 3
		}
		//
		// Summary:
		//     An axis that can be horizontal or vertical.
		public enum Axis
		{
			//
			// Summary:
			//     Horizontal.
			Horizontal = 0,
			//
			// Summary:
			//     Vertical.
			Vertical = 1
		}


		//
		// Summary:
		//     Delegate used for the reapplyDrivenProperties event.
		//
		// Parameters:
		//   driven:
		public delegate void ReapplyDrivenProperties(RectTransform driven);
	}
}