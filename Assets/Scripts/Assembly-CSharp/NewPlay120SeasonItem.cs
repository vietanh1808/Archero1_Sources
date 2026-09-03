using System.Collections.Generic;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class NewPlay120SeasonItem : UITableViewCell, INewPlay120RefreshItem<NewPlay120RewardItemData>
{
	[SerializeField]
	private DxxText curRewardScore;

	[SerializeField]
	private NewPlay120SeasonRewardItem newPlay120RewardItem;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private ScrollRect curScoreScroll;

	[SerializeField]
	private GameObject selectImg;

	private NewPlay120RewardItemData itemData;

	private List<NewPlay120SeasonRewardItem> RewardItemList;

	public void Init(NewPlay120RewardItemData itemData)
	{
	}

	public void RefreshItem(NewPlay120RewardItemData itemData)
	{
	}

	private void CheckCurReward()
	{
	}

	private void CreateReward()
	{
	}

	public void RefreshLanguage()
	{
	}
}
