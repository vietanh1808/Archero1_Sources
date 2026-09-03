using PureMVC.Interfaces;
using UnityEngine;

public class RateUICtrl : MediatorCtrlBase
{
	public RectTransform window;

	public DxxText Text_Title;

	public DxxText Text_Info;

	public DxxText Text_Thanks;

	public DxxText Text_RemindLater;

	public DxxText Text_DonotAsk;

	public DxxText Text_RateUS;

	public ButtonCtrl Button_RemindLater;

	public ButtonCtrl Button_DonotAsk;

	public ButtonCtrl Button_RateUS;

	public ButtonCtrl Button_Close;

	private RateProxy.Transfer mTransfer;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
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
