using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Act5thHuntingRankingRewardItem : UITableViewCell
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

	private Act5thHuntingRankingRewardItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private int selectRank;

	private bool isCurGroup;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingRankingData HuntingRankingData => null;

	private Act5thHuntingRankingItemData SelfData => null;

	private void Init()
	{
	}

	private void InitPool()
	{
	}

	public void Refresh(Act5thHuntingRankingRewardItemData data, int selectRank, bool isCurGroup)
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
