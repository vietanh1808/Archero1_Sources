using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
{
	private Action<PointerEventData> beginDragAction;

	private Action<PointerEventData> dragAction;

	private Action<PointerEventData> endDragAction;

	public void RegisterAction(Action<PointerEventData> begin, Action<PointerEventData> drag, Action<PointerEventData> end)
	{
	}

	public void OnBeginDrag(PointerEventData data)
	{
	}

	public void OnDrag(PointerEventData data)
	{
	}

	public void OnEndDrag(PointerEventData data)
	{
	}
}
