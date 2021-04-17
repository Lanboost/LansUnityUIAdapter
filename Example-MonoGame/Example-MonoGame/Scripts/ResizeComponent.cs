using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResizeComponent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler
{
	public Texture2D cursorTexture;
	private Vector2 lastMousePosition;

	public void Start()
	{
		cursorTexture = AssetLoader.GetTexture("test");
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		Cursor.SetCursor(cursorTexture, new Vector2(12, 12), CursorMode.Auto);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		Cursor.SetCursor(null, new Vector2(0, 0), CursorMode.Auto);
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		Debug.Log("Begin Drag");
		OnDrag(eventData);
	}

	/// <summary>
	/// This method will be called during the mouse drag
	/// </summary>
	/// <param name="eventData">mouse pointer event data</param>
	public void OnDrag(PointerEventData eventData)
	{
		Vector2 currentMousePosition = eventData.position;
		Vector2 diff = (currentMousePosition - lastMousePosition) * new Vector2(1, -1);
		RectTransform rect = transform.parent.GetComponent<RectTransform>();

		//Vector3 newPosition = rect.position + new Vector3(diff.x, diff.y, transform.position.z);
		Vector2 oldPos = rect.sizeDelta;

		rect.sizeDelta = Vector2.Max(new Vector2(40, 40), rect.sizeDelta + diff);
		if (!IsRectTransformInsideSreen(rect))
		{
			rect.sizeDelta = oldPos;
			Debug.Log("Reset");
		}
		//Debug.Log(diff);
		//Debug.Log(rect.sizeDelta);
		lastMousePosition = currentMousePosition;
	}

	/// <summary>
	/// This method will be called at the end of mouse drag
	/// </summary>
	/// <param name="eventData"></param>
	public void OnEndDrag(PointerEventData eventData)
	{
		Debug.Log("End Drag");
		//Implement your funtionlity here


	}

	/// <summary>
	/// This methods will check is the rect transform is inside the screen or not
	/// </summary>
	/// <param name="rectTransform">Rect Trasform</param>
	/// <returns></returns>
	private bool IsRectTransformInsideSreen(RectTransform rectTransform)
	{
		bool isInside = false;
		Vector3[] corners = new Vector3[4];
		rectTransform.GetWorldCorners(corners);
		int visibleCorners = 0;
		Rect rect = new Rect(0, 0, Screen.width, Screen.height);
		foreach (Vector3 corner in corners)
		{
			if (rect.Contains(corner))
			{
				visibleCorners++;
			}
		}
		if (visibleCorners == 4)
		{
			isInside = true;
		}
		return isInside;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		lastMousePosition = eventData.position;
	}
}
