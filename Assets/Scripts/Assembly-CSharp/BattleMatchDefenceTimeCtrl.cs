using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class BattleMatchDefenceTimeCtrl : BattleLevelUICtrl
{
	public BattleMatchDefenceTime_DeadCtrl mDeadCtrl;

	private Transform parent;

	private BattleMatchDefenceTime_ConditionCtrl mCtrl;

	private SequencePool mPool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
