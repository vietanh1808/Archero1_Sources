using UnityEngine;
using XLua;

public class ManorWishInfoPanel : MonoBehaviour
{
	[SerializeField]
	private DxxText text_Title;

	[SerializeField]
	private DxxText text_crtTitle;

	[SerializeField]
	private DxxText text_NextTitle;

	[SerializeField]
	private RectTransform crtParent;

	[SerializeField]
	private RectTransform nextParent;

	[SerializeField]
	private RectTransform nextTitleParnet;

	[SerializeField]
	private PropOneEquip template;

	[SerializeField]
	private ButtonCtrl btn_Close;

	[SerializeField]
	private ButtonCtrl btn_mask;

	public ScrollRectBase scroll;

	private ManorBuildingData crtData;

	private LocalUnityObjctPool pool;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_SetPreview;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public void Init(ManorBuildingData data)
	{
	}

	public void SetPreview(string[] props, bool isCrt)
	{
	}

	public void Refresh()
	{
	}

	private void Close()
	{
	}
}
