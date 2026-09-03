using System;
using PureMVC.Interfaces;

public class ChatTipsUICtrl : MediatorCtrlBase
{
	public class TipsData
	{
		public string title;

		public string content;

		public string sure;

		public Action action;

		public bool needNet;
	}

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Cancel;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public DxxText Text_Cancel;

	private TipsData data;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void init()
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

	private void android_escape()
	{
	}
}
