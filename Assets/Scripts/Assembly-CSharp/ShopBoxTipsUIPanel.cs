using System;
using PureMVC.Interfaces;
using UnityEngine;

public class ShopBoxTipsUIPanel : MediatorCtrlBase
{
	public class TipsData
	{
		public int style;

		public string title;

		public string content;

		public Action okAction;
	}

	public GameObject[] BG;

	public GameObject[] TBG;

	public Color[] SubTitleColor;

	public DxxText Text_Title;

	public DxxText Text_SubTitle;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Cancel;

	public ButtonCtrl Button_OK;

	public DxxText Text_OK;

	public DxxText Text_Cancel;

	public DxxText Text_Check;

	public ButtonCtrl Button_Check;

	public GameObject CheckObj;

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

	private void onButtonOK()
	{
	}

	private void onButtonSwitch()
	{
	}

	private void freshCheck()
	{
	}
}
