using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerListener : EventTrigger
{
	public delegate void VoidDelegate(GameObject go);

	public VoidDelegate onClick;

	public VoidDelegate onDown;

	public VoidDelegate onEnter;

	public VoidDelegate onExit;

	public VoidDelegate onUp;

	public VoidDelegate onSelect;

	public VoidDelegate onUpdateSelect;

	public static EventTriggerListener Get(GameObject go)
	{
		return null;
	}

	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	public override void OnSelect(BaseEventData eventData)
	{
	}

	public override void OnUpdateSelected(BaseEventData eventData)
	{
	}
}
