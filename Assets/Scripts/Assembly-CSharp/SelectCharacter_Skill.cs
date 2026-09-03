using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectCharacter_Skill : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	public Image skillIcon;

	[SerializeField]
	private Image skillBg;

	public Action<SelectCharacter_Skill, object> pointerUpAction;

	public Action<SelectCharacter_Skill, object> pointerDownAction;

	public object param;

	private bool isPointDown;

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void OnDisable()
	{
	}

	public void SetBg(Sprite bg)
	{
	}
}
