using System;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CommonCurrencyBuyConfirmUIPanel : MediatorCtrlBase
{
	public class TipsData
	{
		public int style;

		public string title;

		public string content;

		public CurrencyType icon;

		public string sure;

		public bool showclosebutton;

		public bool showsurebutton;

		public bool showicon;

		public Action callback;
	}

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public Image Image_Icon;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Close;

	public GameObject[] BG;

	public GameObject[] TBG;

	private TipsData mTransfer;

	private float contenty;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
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
