using System;
using System.Collections.Generic;
using NewPlay125;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class TetrisBackpackUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private TetrisContainer mainContainer;

	[SerializeField]
	private ButtonCtrl refreshBtn;

	[SerializeField]
	private ButtonCtrl startBattleBtn;

	[SerializeField]
	private ButtonCtrl confirmBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private Slider lifeSlider;

	[SerializeField]
	private DxxText lifeText;

	[SerializeField]
	private DxxText lifeBgText;

	[SerializeField]
	private DxxText topNoticeText;

	[SerializeField]
	private DxxText coinText;

	[SerializeField]
	private DxxText refreshCoinText;

	[SerializeField]
	private DxxText RefreshText;

	[SerializeField]
	private DxxText BattleText;

	[SerializeField]
	private DxxText ConfirmText;

	private int curWaveNum;

	private int maxWaveNum;

	private int refreshedTimes;

	private int needCoins;

	private int addCoin;

	private int curCoinNum;

	private int destCoinNum;

	private float coinFlyTime;

	private float coinFlyTimeLeft;

	private List<(int, int)> refreshCountList;

	private LocalBackpackVO _LocalSave;

	private List<Vector3> purseList;

	protected override void OnInit()
	{
	}

	private void InitUIComponents()
	{
	}

	private void RecycleTetrisUnit(Action callback)
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnEscape()
	{
	}

	private void closeInternal()
	{
	}

	protected override void OnClose()
	{
	}

	private void SpawnWeapnAndGrids(int times = 0)
	{
	}

	private void GotoBattle()
	{
	}

	public void UpdateLifeInfo()
	{
	}

	private void UpdateWave()
	{
	}

	private void UpdateCoin()
	{
	}

	private void UpdateJumpCoinNum(long num)
	{
	}

	private void RefrershCoinTimes(bool bRefreshNeedCoins = false)
	{
	}

	private void UpdateCoin(int count, List<Vector3> posList = null)
	{
	}

	private void GoldFly(int count, List<Vector3> posList)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
