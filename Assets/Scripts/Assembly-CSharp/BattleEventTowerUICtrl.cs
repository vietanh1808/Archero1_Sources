using System;
using Dxx.Util;
using PureMVC.Interfaces;

public class BattleEventTowerUICtrl : BattleLevelUICtrl
{
	private const int COIN_GROUPS = 100;

	public DxxText txt_cd;

	private SequencePool mSeqPool;

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void UpdateGold()
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private new void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void playGoldAnim(Action<int> setGold, Action battleInUpdateGold)
	{
	}

	private float getCoins()
	{
		return 0f;
	}
}
