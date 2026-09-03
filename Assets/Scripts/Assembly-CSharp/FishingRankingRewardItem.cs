using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class FishingRankingRewardItem : UITableViewCell
{
	[SerializeField]
	private DxxText cupRanking;

	[SerializeField]
	private DxxText normalRanking;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private GameObject selectStatus;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private GameObject cupRankObj;

	[SerializeField]
	private GameObject normalRankObj;

	[SerializeField]
	private Image cupImg;

	private FishingRankingRewardItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private int selectRank;

	private bool isCurGroup;

	private FishingManager FishingManager => null;

	private FishingRankingData FishingRankingData => null;

	private FishingRankingItemData SelfData => null;

	private void Init()
	{
	}

	private void InitPool()
	{
	}

	public void Refresh(FishingRankingRewardItemData data, int selectRank, bool isCurGroup)
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

	private Color GetColor(int rankingNum)
	{
		return default;
	}
}
