using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Exchange2023Item : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private DxxText leftBuyTime;

	[SerializeField]
	private DxxText needCurrency;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private GameObject buyAllStatus;

	[SerializeField]
	private PropOneEquip prop;

	private Exchange2023ItemData itemData;

	private bool isShopA;

	private int curSelectRound;

	private static DelegateBridge __Hotfix0_get_Christmas2023Manager;

	private static DelegateBridge __Hotfix0_get_Exchange2023Data;

	private static DelegateBridge __Hotfix0_get_IsOtherRound;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_checkCanExchange;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Christmas2023Manager Christmas2023Manager => null;

	private Exchange2023Data Exchange2023Data => null;

	private bool IsOtherRound => false;

	public void Refresh(Exchange2023ItemData itemData, bool isShopA, int curSelectRound)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshStatus()
	{
	}

	private bool checkCanExchange()
	{
		return false;
	}

	private void Click()
	{
	}

	private void RequestReward()
	{
	}
}
