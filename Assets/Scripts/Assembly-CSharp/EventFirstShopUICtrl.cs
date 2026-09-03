using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class EventFirstShopUICtrl : MediatorCtrlBase
{
	public const int FirstShopCount = 2;

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public GameObject copyitems;

	public GameObject copyitem;

	public GameObject itemsparent;

	private List<bool> goodbuy;

	private LocalUnityObjctPool mPool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void OnClickBuy(FirstItemOnectrl one)
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
