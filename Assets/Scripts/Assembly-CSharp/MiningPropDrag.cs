using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

public class MiningPropDrag : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public Image Image_Prop;

	public int index;

	public DxxImage Image_Selected;

	private int propID;

	private Canvas _canvas;

	private bool isUse;

	private static DelegateBridge __Hotfix0_Start;

	private static DelegateBridge __Hotfix0_OnBeginDrag;

	private static DelegateBridge __Hotfix0_OnDrag;

	private static DelegateBridge __Hotfix0_OnEndDrag;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Start()
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
}
