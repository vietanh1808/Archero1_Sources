using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Act5thHuntingGameSceneTrigger : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private Action<Vector2> pointerClick;

	public void Refresh(Action<Vector2> pointerClick)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
