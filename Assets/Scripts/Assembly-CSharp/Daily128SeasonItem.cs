using System.Collections.Generic;
using GameProtocol;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Daily128SeasonItem : UITableViewCell
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

	private List<NewPlay120SeasonRewardItem> RewardItemList;

	public void Refresh(STActivityArtifactPointRewardData data)
	{
	}
}
