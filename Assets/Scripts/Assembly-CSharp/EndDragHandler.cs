using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class EndDragHandler : MonoBehaviour, IEndDragHandler, IEventSystemHandler
{
	public Action action;

	public void OnEndDrag(PointerEventData eventData)
	{
	}
}
