using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampShopItem : UITableViewCell
{
	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private GameObject mask;

	[SerializeField]
	private GameObject maskDiscount;

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText leftCount;

	[SerializeField]
	private Image currencyIcon;

	[SerializeField]
	private DxxText currencyCount;

	[SerializeField]
	private GameObject discount;

	[SerializeField]
	private DxxText discountTitle;

	[SerializeField]
	private DxxText discountCount;

	[SerializeField]
	private PropOneEquip reward;

	private CampShopItemData itemData;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshReward;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_checkCanExchange;

	private static DelegateBridge __Hotfix0_sendBuyItem;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(CampShopItemData data)
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshReward()
	{
	}

	private void Click()
	{
	}

	private bool checkCanExchange()
	{
		return false;
	}

	private void sendBuyItem()
	{
	}
}
