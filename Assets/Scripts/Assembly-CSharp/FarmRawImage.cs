using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FarmRawImage : RawImage, IPointerClickHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	private Camera UICamera;

	private Farm3D farm3d;

	private Vector2 begin;

	public void setFarm3D(Farm3D farm3d, Camera camera)
	{
	}

	void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
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

	private void setCameraOffset(PointerEventData eventData)
	{
	}
}
