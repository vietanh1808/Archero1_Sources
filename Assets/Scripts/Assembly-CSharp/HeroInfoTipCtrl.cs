using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class HeroInfoTipCtrl : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	private bool isPointDown;

	public Action PointerUpAction;

	public Action PointerDownAction;

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void OnDisable()
	{
	}
}
