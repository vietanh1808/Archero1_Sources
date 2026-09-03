using System;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class DailyBackRewardButtonItem : MonoBehaviour, INewPlay120RefreshItem<DailyBackRewardButtonItemData>
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private DxxText countText;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private DxxText rateTex;

	private DailyBackRewardButtonItemData itemData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshInfo;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshGold;

	private static DelegateBridge __Hotfix0_RefreshDiamond;

	private static DelegateBridge __Hotfix0_RefreshKey;

	private static DelegateBridge __Hotfix0_RefreshReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(DailyBackRewardButtonItemData itemData)
	{
	}

	public void RefreshItem(DailyBackRewardButtonItemData itemData)
	{
	}

	private void RefreshInfo()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshGold(int needCount)
	{
	}

	private void RefreshDiamond(int needCount)
	{
	}

	private void RefreshKey(int needCount)
	{
	}

	private void RefreshReward(bool reachCond, Action unreachedCond)
	{
	}
}
