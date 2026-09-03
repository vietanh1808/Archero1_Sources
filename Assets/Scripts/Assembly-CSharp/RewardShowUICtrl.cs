using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class RewardShowUICtrl : MediatorCtrlBase
{
	private enum EState
	{
		eDoing = 0,
		eDone = 1
	}

	public BoxOpenGetCtrl mGetCtrl;

	public ButtonCtrl mButtonClose;

	public TapToCloseCtrl mTapCloseCtrl;

	public ButtonCtrl Button_Shadow;

	public GameObject copyitems;

	private RewardShowProxy.Transfer mTransfer;

	private List<Drop_DropModel.DropData> mEquipTransfer;

	private int currentIndex;

	private EState mState;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void ExcuteEquips()
	{
	}

	private int GetHaveCount(int id)
	{
		return 0;
	}

	private void show_close(bool value)
	{
	}

	private void InitUI()
	{
	}

	private void OnOneUIClose()
	{
	}

	private void PlayCurrent()
	{
	}

	private void OnScrollEnd()
	{
	}

	private void PlayGet()
	{
	}

	private void OnClickShadow()
	{
	}

	private void ChangeState(EState state)
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
