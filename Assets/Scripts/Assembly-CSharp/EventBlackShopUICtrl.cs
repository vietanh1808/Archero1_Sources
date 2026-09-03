using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class EventBlackShopUICtrl : MediatorCtrlBase
{
	private const float width = 200f;

	private const float height = 240f;

	private const int LineCount = 4;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Close;

	public ButtonCtrl Button_Close;

	public GameObject items;

	public GameObject DiscountText;

	private GameObject _itemone;

	private List<BlackItemOnectrl> mList;

	private LocalUnityObjctPool mPool;

	private List<Shop_MysticShop> mDataList;

	private List<int> buys;

	private int diamondforcoin;

	private List<int> shows;

	private int shoptype;

	private MysteriesSource mySource;

	private int myDailyId;

	protected EventBlackShopProxy.Transfer mTransfer;

	private GameObject itemone => null;

	protected override void OnInit()
	{
	}

	protected virtual WindowID GetWindowID()
	{
		return WindowID.WindowID_Invaild;
	}

	protected virtual MysteriesSource GetSource()
	{
		return MysteriesSource.LEVEL;
	}

	protected virtual int GetShopType()
	{
		return 0;
	}

	protected override void OnOpen()
	{
	}

	protected virtual List<Shop_MysticShop> GetDatas()
	{
		return null;
	}

	private void InitUI()
	{
	}

	private void OnClickBuy(BlackItemOnectrl one)
	{
	}

	private void OnClickBuyInternal(BlackItemOnectrl one)
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	private void UpdateCurrency()
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

	protected virtual void ShowTips(string tips)
	{
	}
}
