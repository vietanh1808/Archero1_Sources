using System;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class GodWishUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public Image Image_Ticket;

	public DxxText Text_Ticket;

	public ButtonCtrl Button_Ticket;

	public ButtonCtrl[] Button_Box;

	public DxxText[] Text_Box;

	public GameObject[] BoxBlastAni;

	public GameObject[] BoxFlyAni;

	public ScrollRect scrollRect;

	public RectTransform ContentOne;

	public GameObject cpItem;

	public DxxText TopRateDesc;

	public DxxText BottomRateDesc;

	public DxxText Text_ScratchTitle;

	public DxxText Text_Scratch;

	public ButtonCtrl Button_Record;

	public RectTransform ScratchTitleLayout;

	public Image[] Image_Flag;

	public GodWishShowItem[] ticketItems;

	public ButtonCtrl Button_Task;

	public DxxText Text_Task;

	public ButtonCtrl Button_Auto;

	public DxxText Text_Auto;

	public ButtonCtrl Button_Shop;

	public DxxText Text_Shop;

	public GodWishEraseTool eraseTool;

	public GameObject PopRewardWindow;

	public RectTransform PopContainer;

	public RectTransform PanelRect;

	public GameObject TicketNull;

	public DxxText Text_TicketNull;

	public GameObject TicketCorner;

	public DxxText Text_Corner;

	public GameObject RedPoint_Task;

	public GameObject RedPoint_Shop;

	public GameObject Guider;

	private bool isAutoing;

	private bool isCancelAuto;

	public GameObject Mask;

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

	private void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}

	private void Esc()
	{
	}

	private void onButtonShop()
	{
	}

	public void openTicketBuyUI()
	{
	}

	private void onButtonTicket()
	{
	}

	private void onButtonRecord()
	{
	}

	private void onButtonTask()
	{
	}

	private void onButtonBox2()
	{
	}

	private void onButtonBox3()
	{
	}

	private void onButtonBox4()
	{
	}

	private void showBoxReward(int index)
	{
	}

	private void initUI()
	{
	}

	private void freshTime()
	{
	}

	private void freshTopReward()
	{
	}

	private void freshTopTicket()
	{
	}

	public void freshGodShow()
	{
	}

	private void freshGodTicket()
	{
	}

	private void freshTopPreviewCover()
	{
	}

	private void freshRedPoint()
	{
	}

	public void freshTicketNull()
	{
	}

	public void freshGuideShow()
	{
	}

	public void scratchTicketOne()
	{
	}

	public void recoverTicketOne()
	{
	}

	public void showTicketReward(Action action, bool auto)
	{
	}

	public void showTicketRewardAuto(Action action)
	{
	}

	public void showPopReward(int index)
	{
	}

	public void onButtonAuto()
	{
	}

	private void doAuto()
	{
	}

	private void beginScratch()
	{
	}

	public bool checkCanScratch()
	{
		return false;
	}

	public void setAutoButtonState(bool touch)
	{
	}

	public void setAutoShow()
	{
	}

	public void onButtonTouchScreen()
	{
	}
}
