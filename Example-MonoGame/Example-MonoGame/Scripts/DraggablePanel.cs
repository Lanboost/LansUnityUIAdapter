﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggablePanel : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler
{
	private Vector2 lastMousePosition;


	/// <summary>
	/// This method will be called on the start of the mouse drag
	/// </summary>
	/// <param name="eventData">mouse pointer event data</param>
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
		Vector2 diff = currentMousePosition - lastMousePosition;
		RectTransform rect = GetComponent<RectTransform>();
		Vector2 oldPos1 = rect.offsetMin;
		Vector2 oldPos2 = rect.offsetMax;
		rect.offsetMin += new Vector2(diff.x, diff.y);
		rect.offsetMax += new Vector2(diff.x, diff.y);
		if (!IsRectTransformInsideSreen(rect))
		{
			rect.offsetMin = oldPos1;
			rect.offsetMax = oldPos2;
		}
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
		Debug.Log("Clicked draggable");
		lastMousePosition = eventData.position;
	}

}