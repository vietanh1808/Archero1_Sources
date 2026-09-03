using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingRankingItem : UITableViewCell
{
	[SerializeField]
	private DxxText ranking;

	[SerializeField]
	private DxxText normalRanking;

	[SerializeField]
	private DxxText rankingScore;

	[SerializeField]
	private DxxText playerName;

	[SerializeField]
	private HeadItem headItem;

	[SerializeField]
	private MedalItem medalItem;

	[SerializeField]
	private ButtonCtrl chestBtn;

	[SerializeField]
	private ButtonCtrl headBtn;

	[SerializeField]
	private ButtonCtrl rewardTipBtn;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private GameObject cupRankObj;

	[SerializeField]
	private GameObject normalRankObj;

	[SerializeField]
	private Image cupImg;

	[SerializeField]
	private GameObject chestObj;

	[SerializeField]
	private Image chestImg;

	private FishingRankingItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private int curSelectIndex;

	private RectTransform _scrollViewRect;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshUserInfo;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_ClickChest;

	private static DelegateBridge __Hotfix0_ClickUserInfo;

	private static DelegateBridge __Hotfix0_ClickTip;

	private static DelegateBridge __Hotfix0_GetColor;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	public void Refresh(FishingRankingItemData data, int curSelectIndex, RectTransform scrollRect = null)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshUserInfo()
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickChest()
	{
	}

	private void ClickUserInfo()
	{
	}

	private void ClickTip()
	{
	}

	private Color GetColor(int rankingNum)
	{
		return default;
	}

	private void Update()
	{
	}

	public void Close()
	{
	}
}
