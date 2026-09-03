using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

public class CampMapEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	private CampMainUI campUI;

	private CampMap cmap;

	private Vector2 begin;

	private int dragCount;

	private static DelegateBridge __Hotfix0_setCampMainUI;

	private static DelegateBridge __Hotfix0_setCampMap;

	private static DelegateBridge __Hotfix0_UnityEngine_002EEventSystems_002EIPointerClickHandler_002EOnPointerClick;

	private static DelegateBridge __Hotfix0_OnBeginDrag;

	private static DelegateBridge __Hotfix0_OnDrag;

	private static DelegateBridge __Hotfix0_OnEndDrag;

	private static DelegateBridge __Hotfix0_handleOffset;

	private static DelegateBridge __Hotfix0_handleClick;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void setCampMainUI(CampMainUI campUI)
	{
	}

	public void setCampMap(CampMap map)
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

	private void handleOffset(PointerEventData eventData)
	{
	}

	private void handleClick(Vector2 v2)
	{
	}
}
