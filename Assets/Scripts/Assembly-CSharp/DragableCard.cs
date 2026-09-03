using UnityEngine;
using UnityEngine.EventSystems;

public class DragableCard : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private void SetDraggedPosition(PointerEventData eventData)
	{
	}
}
