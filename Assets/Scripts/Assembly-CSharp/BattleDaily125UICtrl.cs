using NewPlay125;
using PureMVC.Interfaces;
using UnityEngine;

public class BattleDaily125UICtrl : BattleLevelUICtrl
{
	[SerializeField]
	private NewPlay125WeaponSkill weaponSkill;

	[SerializeField]
	private DxxText bagCoinText;

	[SerializeField]
	private DxxText waveData;

	[SerializeField]
	private GameObject waveDataObj;

	[SerializeField]
	private GameObject bagCoinObj;

	[SerializeField]
	private RectTransform bagCoinRect;

	[SerializeField]
	private RectTransform goldCoinRect;

	[SerializeField]
	private RectTransform expRect;

	[SerializeField]
	private RectTransform bossHpRect;

	[SerializeField]
	private RectTransform waveRect;

	[SerializeField]
	private NewPlay125GameSpeedUpItem speedUpItem;

	[SerializeField]
	private RectTransform speedUpItemRect;

	private bool expStatus;

	private bool expCurStatus;

	private bool isBossHpShow;

	private NewPlay125Manager NewPlay125Manager => null;

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

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void ShowBossHP(bool show)
	{
	}

	private void CheckReachMaxLevel()
	{
	}

	private void RefreshBagCoinCount()
	{
	}

	private void RefreshWaveData(int finishedWave, int maxWave)
	{
	}

	private void OnWaveGameStart()
	{
	}

	private void OnWaveGameEnd(int finishedWave, int maxWave)
	{
	}

	private void RefreshStatus()
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void RefreshAnchored()
	{
	}
}
