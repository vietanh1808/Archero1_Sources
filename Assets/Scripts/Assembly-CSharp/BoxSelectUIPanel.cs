using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class BoxSelectUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Desc;

	public DxxText Text_Count;

	public PropOneEquip topItem;

	public RectTransform RT_Content;

	public GameObject cpItem;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Use;

	public DxxText Text_Use;

	private int boxId;

	private int Total;

	private List<BoxSelectItem> itemList;

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

	private void onButtonUse()
	{
	}

	private void changeItemReduce(int index)
	{
	}

	private void changeItemPlus(int index)
	{
	}

	private void calcuteItemCount()
	{
	}

	private int GetChoosedCount()
	{
		return 0;
	}
}
