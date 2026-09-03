using System.Collections.Generic;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class MonopolyRankRewardItem : UITableViewCell
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

	private MonopolyRankRewardItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private List<string> rewards;

	private void Init()
	{
	}

	private void InitPool()
	{
	}

	public void Refresh(MonopolyRankRewardItemData data)
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
