using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CashGiftUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Info;

	public DxxText Text_Title;

	public DxxText Text_TimeEnd;

	public DxxText Text_TimeRewardEnd;

	public ButtonCtrl Button_Back;

	public ButtonCtrl Button_Gift;

	public ButtonCtrl Button_Task;

	public RectTransform Window;

	public GameObject GiftPanel;

	public CashGiftTaskUI taskPanel;

	public GameObject Icon_Gift;

	public GameObject RedPoint_Gift;

	public GameObject Icon_Task;

	public GameObject RedPoint_Task;

	private int currentTab;

	private bool isTaskEnd;

	public CashGiftItemCell BigCellItem;

	public CashGiftItemCell cellItem;

	public VerticalLayoutGroup cellParent;

	public RectTransform view;

	private List<LocalSave.CashGiftItemData> cashDataList;

	private List<CashGiftItemCell> cashItemList;

	private int lastIndex;

	private int lastShowId;

	public GameObject PopWindow;

	public GameObject PopArrow;

	public DxxText Text_PopTitle;

	public DxxText Text_PopDesc;

	public PropOneEquip Pop_Reward;

	private float timer;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void android_escape()
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

	private void init()
	{
	}

	private void SetCountDown()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonBack()
	{
	}

	private void onButtonGift()
	{
	}

	private void onButtonTask()
	{
	}

	private void RefreshTableView()
	{
	}

	public void OnValueChange(Vector2 pos)
	{
	}

	private void RefreshBigReward()
	{
	}

	private LocalSave.CashGiftItemData GetMaxBigGift()
	{
		return null;
	}

	public void openPopWindow(Vector3 position)
	{
	}

	public void hidePopWindow()
	{
	}

	private void Update()
	{
	}
}
