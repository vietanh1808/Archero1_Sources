using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

public class ManorTouchHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public RectTransform MainUI;

	public RectTransform Rect_BG;

	private Vector2 begin;

	private float minx;

	private float miny;

	private float maxx;

	private float maxy;

	private static DelegateBridge __Hotfix0_Start;

	private static DelegateBridge __Hotfix0_UnityEngine_002EEventSystems_002EIPointerClickHandler_002EOnPointerClick;

	private static DelegateBridge __Hotfix0_OnBeginDrag;

	private static DelegateBridge __Hotfix0_OnDrag;

	private static DelegateBridge __Hotfix0_OnEndDrag;

	private static DelegateBridge __Hotfix0_handleOffset;

	private static DelegateBridge __Hotfix0_LocationToBuild;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Start()
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

	public void LocationToBuild(float bx, float by)
	{
	}
}
