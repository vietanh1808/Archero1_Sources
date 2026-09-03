using UIKit;
using UnityEngine;
using XLua;

public class HalloweenExcItem : UITableViewCell
{
	[SerializeField]
	private DxxText text_Limit;

	[SerializeField]
	private DxxText text_Price;

	[SerializeField]
	private DxxText text_Discount;

	[SerializeField]
	private DxxText text_DiscountContent;

	[SerializeField]
	private ButtonCtrl btn_Get;

	[SerializeField]
	private DxxImage icon_NeedProp;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private GameObject goDiscount;

	[SerializeField]
	private GameObject goMask;

	private LocalUnityObjctPool propPool;

	private HalloweenExchangeItemData itemData;

	private bool isInit;

	private float itemSize;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_OnBtnGetClick;

	private static DelegateBridge __Hotfix0_checkCanBuy;

	private static DelegateBridge __Hotfix0_OnConfimBtnClick;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	public void Refresh(HalloweenExchangeItemData data)
	{
	}

	public void OnBtnGetClick()
	{
	}

	private bool checkCanBuy()
	{
		return false;
	}

	public void OnConfimBtnClick(int buyCount)
	{
	}

	public void RefreshItem()
	{
	}
}
