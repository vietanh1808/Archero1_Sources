using System.Collections.Generic;
using Dxx.Util;
using GameProtocol;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class EventBlackAdShopUICtrl : MediatorCtrlBase, AdsRequestHelper.AdsCallback
{
	private const float width = 200f;

	private const float height = 240f;

	private const int LineCount = 4;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Close;

	public DxxText Text_Start;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Start;

	public RectTransform image_ad;

	public GameObject items;

	private GameObject _itemone;

	private List<BlackAdItemOnectrl> mList;

	private LocalUnityObjctPool mPool;

	private List<Shop_MysticShop> mDataList;

	private Shop_MysticShop mDataOne;

	private List<int> shows;

	private int shoptype;

	private bool bOpened;

	private bool bReward;

	private SequencePool mSeqPool;

	private MysteriesSource mySource;

	private int myDailyId;

	private float text_startx;

	private GameObject itemone => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void add_equipexp(CEquipmentItem item)
	{
	}

	private void android_escape()
	{
	}

	private void get_success()
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

	public void onRequest(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onLoad(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onFail(AdsRequestHelper.AdsDriver sender, string msg)
	{
	}

	public void onOpen(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClose(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClick(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	private void onRewardWrapper(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onReward(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	private void onRewardInternal(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}
}
