using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class BoxSelectTipsUIPanel : MediatorCtrlBase
{
	public class BoxSelectChooseData
	{
		public int boxId;

		public List<string> chooseList;
	}

	public DxxText Text_Title;

	public DxxText Text_Desc;

	public RectTransform RT_Content;

	public GameObject cpItem;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Cancel;

	public DxxText Text_Sure;

	public DxxText Text_Cancel;

	private BoxSelectChooseData chooseData;

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

	private void android_escape()
	{
	}

	private void initUI()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonSure()
	{
	}
}
