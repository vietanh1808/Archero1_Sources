using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class DailyBackRewardItem : MonoBehaviour, INewPlay120RefreshItem<DailyBackRewardItemData>
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText subTitle;

	[SerializeField]
	private Transform rewardItemParent;

	[SerializeField]
	private PropOneEquip_Port rewardItem;

	[SerializeField]
	private Transform rewardItemButtonParent;

	[SerializeField]
	private DailyBackRewardButtonItem rewardItemButton;

	[SerializeField]
	private GameObject rewardCompleteGo;

	[SerializeField]
	private Image rewardBg;

	[SerializeField]
	private Image rewardItemBg;

	[SerializeField]
	private ScrollRect rewardScroll;

	private List<PropOneEquip_Port> createRewardItem;

	private List<DailyBackRewardButtonItem> createRewardItemButton;

	private DailyBackRewardItemData itemData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix1_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshScroll;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(DailyBackRewardItemData itemData)
	{
	}

	public void RefreshItem(DailyBackRewardItemData itemData)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshScroll()
	{
	}
}
