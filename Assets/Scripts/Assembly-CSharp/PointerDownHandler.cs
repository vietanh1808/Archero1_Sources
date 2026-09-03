using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerDownHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	public Action action;

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
