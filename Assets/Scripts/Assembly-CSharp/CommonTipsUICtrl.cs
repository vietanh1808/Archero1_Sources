using System;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CommonTipsUICtrl : MediatorCtrlBase
{
	public class TipsData
	{
		public string title;

		public string content;

		public string okText;

		public bool cancel;

		public Action action;

		public Action closeAction;

		public int style;

		public string checkDesc;

		public bool isCheck;
	}

	public GameObject[] BG;

	public GameObject[] TBG;

	public ButtonCtrl Button_Cancel;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Close;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public DxxText Text_Cancel;

	public GameObject checkObj;

	public GameObject checkConfirmObj;

	public DxxText Text_check;

	public Button checkButton;

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

	private void ClickCheck()
	{
	}
}
