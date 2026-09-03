using Activity.Anniversary;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class OpenBoxUIPanel : MediatorCtrlBase
{
	public GameObject Panel_Pre;

	public GameObject Panel_Ing;

	public DxxText Text_PreTitle;

	public DxxText Text_PreDesc;

	public ButtonCtrl btnClose;

	public InfoPopPanel infoPopPanel;

	public ButtonCtrl button_bg;

	[SerializeField]
	private RedNodeCtrl bagRedNodeCtrl;

	[SerializeField]
	private RedNodeCtrl RedPoint_ExchBtn_Ctrl;

	[SerializeField]
	private RedNodeCtrl RedPoint_GetBtn_Ctrl;

	private long showTimexReady;

	public ButtonCtrl Btn_activity_Info;

	public GameObject Panel_Bag;

	public GameObject Panel_Exch;

	public DxxText Text_Time;

	public Act4thBoxQueueItem[] queueItems;

	public DxxText[] Tab_Title;

	public GameObject[] Tab_Focus;

	public DxxText Text_QueueKey;

	public DxxText Text_ItemB;

	public DxxText Text_ItemC;

	public Act4thBoxItem[] boxItems;

	public ButtonCtrl Button_Put;

	public DxxText Text_Put;

	public ButtonCtrl Button_Task;

	public DxxText Text_Task;

	public RedNodeCtrl RedPoint_Task_Ctrl;

	public DxxText Exch_Title;

	public DxxText Exch_Left;

	public ButtonCtrl Exch_ButtonGet;

	public ButtonCtrl Exch_ButtonExch;

	public DxxText Exch_TextGet;

	public DxxText Exch_TextExch;

	public DxxText[] Exch_Items;

	public DxxImage[] Exch_ItemIcons;

	public Slider Exch_Slider;

	public DxxText Exch_SliderCount;

	public ButtonCtrl Button_Info;

	public RedNodeCtrl RedPoint_Exch_Ctrl;

	public DxxText Exch_BottomLeft;

	private static Color Color_Green;

	private int[] boxArray;

	private int currentTab;

	private long showTimex;

	private int chooseBoxIndex;

	public DxxText text_title;

	protected override void OnInit()
	{
	}

	private void UpdateTime_Ready()
	{
	}

	protected override void OnOpen()
	{
	}

	private void Esc()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void initUI()
	{
	}

	private void initTime()
	{
	}

	private void UpdateTime()
	{
	}

	private void initItemKey()
	{
	}

	private void initItemBC()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void showTab(int tab)
	{
	}

	private void initQueue()
	{
	}

	private void initBag()
	{
	}

	private void initExch()
	{
	}

	private void onButtonPut()
	{
	}

	private void onButtonTask()
	{
	}

	private void onButtonExch()
	{
	}

	private bool IsCanExchange()
	{
		return false;
	}

	private void onButtonGet()
	{
	}

	private void onButtonInfo()
	{
	}

	private void OnActivityInfo()
	{
	}

	public void onButtonItemDesc(bool isDropB)
	{
	}

	public void RefreshBagRedNode()
	{
	}
}
