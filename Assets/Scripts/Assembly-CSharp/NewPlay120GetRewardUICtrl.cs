using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class NewPlay120GetRewardUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText subTitle;

	[SerializeField]
	private DxxText rewardSeasonTitle;

	[SerializeField]
	private DxxText lastSeasonDesc;

	[SerializeField]
	private DxxText getRewardBtnName;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private PropOneEquip rewardItem;

	[SerializeField]
	private ButtonCtrl getRewardBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	private NewPlay120GetRewardData NewPlay120GetRewardData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void CreateReward()
	{
	}

	private void GetReward()
	{
	}

	private List<Drop_DropModel.DropData> TurnRewardData(string[] rewardsStr)
	{
		return null;
	}

	private void android_escape()
	{
	}
}
