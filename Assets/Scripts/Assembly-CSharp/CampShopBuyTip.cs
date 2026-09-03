using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampShopBuyTip : MonoBehaviour
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText needCount;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private ButtonCtrl closeMask;

	[SerializeField]
	private DxxText leftCount;

	[SerializeField]
	private PropOneEquip reward;

	[SerializeField]
	private Image currencyIcon;

	private CampShopItemData data;

	private static DelegateBridge __Hotfix0_get_CampShopManager;

	private static DelegateBridge __Hotfix0_get_CampShopData;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampShopManager CampShopManager => null;

	private CampShopData CampShopData => null;

	public void Show(CampShopItemData data)
	{
	}

	public void Refresh()
	{
	}

	private void Click()
	{
	}
}
