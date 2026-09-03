using UnityEngine;

public class BeastIslandUI : MediatorCtrlBase
{
	public BeastIslandDifficultyPart beastIslandDifficultyPart;

	public BeastIslandAllReward beastIslandAllReward;

	public DxxText titleTex;

	public DxxText descTex;

	public DxxText pregressDex;

	public DxxText battleBtnTex;

	public DxxText battleBtnNumTex;

	public DxxText sweepBtnTex;

	public DxxText sweepBtnNumTex;

	public DxxText sweepLockTex;

	public DxxText timeTex;

	public DxxText limitCountTex;

	public ButtonCtrl closeBtn;

	public ButtonCtrl tipsBtn;

	public ButtonCtrl battleBtn;

	public ButtonCtrl sweepBtn;

	public SailingRankShowItem rankShowItem;

	[SerializeField]
	private Transform sweepFlyTarget;

	[SerializeField]
	private Transform sweepFlyStart;

	private BeastIslandDifficultyItemData mCurDifficult;

	private int oldProgressValue;

	private int openIndex;

	private int flyStartOpenIndex;

	private int CurProgressValue => 0;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshUI(bool isSweep = false)
	{
	}

	private void RegisterEvent()
	{
	}

	private void UnRegisterEvent()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshReward(bool isSuccess)
	{
	}

	private void RefreshSweep(bool isSuccess)
	{
	}

	private void RefreshInfo(bool isSuccess)
	{
	}

	private void ClickClose()
	{
	}

	private void ClickTips()
	{
	}

	private void ClickBattle()
	{
	}

	private void ClickSweep()
	{
	}

	private void ClickDifficultyItem(BeastIslandDifficultyItemData difficulty)
	{
	}

	private void OnClickDifficultyItem(BeastIslandDifficultyItemData difficulty)
	{
	}

	private void Refresh()
	{
	}

	private void freshTime()
	{
	}

	private void OnCloseSweepShowRewardWindow()
	{
	}

	private void OnUpdateByFlyAni(long curAddNum)
	{
	}

	private void OnFlyAniFinished()
	{
	}
}
