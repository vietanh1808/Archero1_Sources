using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingBestiaryItem : UITableViewCell
{
	[SerializeField]
	private DxxText qualityName;

	[SerializeField]
	private FishingBestiaryFishItem fishItem;

	[SerializeField]
	private Transform fishParent;

	[SerializeField]
	private Image titleBg;

	[SerializeField]
	private Image bg;

	[SerializeField]
	private LayoutElement titleBgLayout;

	[SerializeField]
	private LayoutElement contentLayout;

	[SerializeField]
	private GridLayoutGroup gridLayoutGroup;

	[SerializeField]
	private VerticalLayoutGroup verticalLayoutGroup;

	private FishingBestiaryItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private static DelegateBridge __Hotfix0_InitPool;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_GetFixHeight;

	private static DelegateBridge __Hotfix0_GetMinContentHeight;

	private static DelegateBridge __Hotfix0_GetGridLayoutGroup;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void InitPool()
	{
	}

	private void Init()
	{
	}

	public void Refresh(FishingBestiaryItemData data)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	public float GetFixHeight()
	{
		return 0f;
	}

	public float GetMinContentHeight()
	{
		return 0f;
	}

	public GridLayoutGroup GetGridLayoutGroup()
	{
		return null;
	}
}
