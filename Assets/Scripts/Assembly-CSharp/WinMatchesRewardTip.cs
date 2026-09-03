using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class WinMatchesRewardTip : MonoBehaviour
{
	public RectTransform tipPosition;

	public RectTransform tipBg;

	public RectTransform tipBgTip;

	public DxxText textTitle;

	public BattlePass_ChestPropOne propTemplate;

	public RectTransform equipContainer;

	protected List<BattlePass_ChestPropOne> props;

	public void refresh(Farm_VictoryReward victoryRewards)
	{
	}

	public void onClick()
	{
	}
}
