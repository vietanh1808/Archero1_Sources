using System;
using PureMVC.Interfaces;
using UnityEngine;

public class ShopWorkerTipsUIPanel : MediatorCtrlBase
{
	public class TipsData
	{
		public int diamond;

		public Action action;
	}

	public ButtonCtrl Button_Cancel;

	public DxxText Text_Cancel;

	public ButtonCtrl Button_Sure;

	public DxxText Text_Sure;

	public ButtonCtrl Button_Close;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Diamond;

	public DxxText Text_Desc;

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
}
