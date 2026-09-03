using System;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class FarmTipsUICtrl : MediatorCtrlBase
{
	public class TipsData
	{
		public string title;

		public string content;

		public string okText;

		public Action action;

		public CurrencyType type;

		public Action Action_Cancel;
	}

	private TipsData data;

	public ButtonCtrl Button_Cancel;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Close;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public GameObject CurrencyNode;

	public Image Image_Icon;

	public DxxText Text_Currency;

	public DxxText Text_Sure;

	public DxxText Text_Cancel;

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
