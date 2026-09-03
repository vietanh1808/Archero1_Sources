using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class BoxSelectPreviewUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Desc;

	public PropOneEquip topItem;

	public RectTransform RT_Content;

	public GameObject cpItem;

	public ButtonCtrl Button_Close;

	private int boxId;

	private List<BoxSelectItemData> itemList;

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
}
