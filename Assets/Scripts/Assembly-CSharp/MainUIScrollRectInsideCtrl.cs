using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainUIScrollRectInsideCtrl : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
{
	public ScrollRectBase anotherScrollRect;

	public bool thisIsUpAndDown;

	public Action Event_OnClick;

	private ScrollRectBase thisScrollRect;

	private bool bFirstDrag;

	private void Awake()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
