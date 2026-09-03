using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingPreSignUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public DxxText Text_Time;

	public DxxText Text_Desc;

	public RectTransform Container;

	public GameObject cpItem;

	private List<SailingPreSignItem> itemList;

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

	private void Esc()
	{
	}

	public void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	private void freshTime()
	{
	}

	private void freshUI()
	{
	}
}
