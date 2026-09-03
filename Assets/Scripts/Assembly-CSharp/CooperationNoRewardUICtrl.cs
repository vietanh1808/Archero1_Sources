using System;
using PureMVC.Interfaces;

public class CooperationNoRewardUICtrl : MediatorCtrlBase
{
	public class Transfer
	{
		public int type;

		public Action callback;
	}

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public DxxText Text_Cancel;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Cancel;

	public ButtonCtrl Button_Shadow;

	private Transfer mTransfer;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
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
