using System.Collections.Generic;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ActivityShipUICtrl : MediatorCtrlBase
{
	public RectTransform window;

	public ButtonCtrl closeBtn;

	public ButtonCtrl driveBtn;

	public GameObject driveBtnMask;

	public Transform ShipItemBg;

	public ActivityNormalShipItemCtrl ShipNormalItem;

	public ActivityPayShipItemCtrl ShipPayItem;

	public ActivityMazeItemCtrl MazeItem;

	public ActivityPVPItemCtrl PVPItem;

	public RectTransform content;

	public DxxText Text_time;

	public DxxText Text_Title;

	public DxxText Text_drive;

	public Image Img_Title1;

	public Image Img_Title2;

	public GameObject Bottom;

	public ButtonCtrl[] bottomButton;

	public UITween[] buttonTween;

	public UISizeTween[] buttonSizeTween;

	public DxxText[] Btn_title;

	public ButtonCtrl Button_tip;

	public ButtonCtrl Button_tipClose;

	[SerializeField]
	private ButtonCtrl Button_refresh;

	[SerializeField]
	private DxxText Text_btnRefresh;

	[SerializeField]
	private DxxText Text_btnRefreshCount;

	[SerializeField]
	private DxxText Text_refreshCost;

	public GameObject TipObject;

	public DxxText Text_tipTitle;

	public DxxText Text_tipDesc;

	public GameObject ReshowObject;

	public DxxImage Image_resIcon;

	public DxxText Text_resNum;

	private List<CActivityShipNormalItem> NormalItems;

	private List<CActivityShipPayItem> PayItems;

	private List<ActivityMazeItemCtrl> MazeItems;

	private List<ActivityPVPItemCtrl> PVPItems;

	private LocalUnityObjctPool mPool;

	private int vol;

	private float height;

	private float itemheight;

	private float bgOff;

	private float countdown;

	private int curTab;

	public int CurShipType;

	private bool refreshingTab;

	public ButtonCtrl refreshOpenBtn;

	public GameObject refreshPopObj;

	public Button refreshCloseBtn;

	public DxxText refreshPopTitle;

	public DxxText refreshPopContent;

	public ActShipRelicsGiftBoxItem relicsBoxItem;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_closeWindow;

	private static DelegateBridge __Hotfix0_getEndTime;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_refreshPayShipCtrl;

	private static DelegateBridge __Hotfix0_refresh_text_drive;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_ShowItems;

	private static DelegateBridge __Hotfix0_LoadPaidItems;

	private static DelegateBridge __Hotfix0_LoadNormalItems;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_showItemBG;

	private static DelegateBridge __Hotfix0_ClearItems;

	private static DelegateBridge __Hotfix0_DetoryChilds;

	private static DelegateBridge __Hotfix0_ShowNormalItems;

	private static DelegateBridge __Hotfix0_ShowPayItems;

	private static DelegateBridge __Hotfix0_ShowMazeItems;

	private static DelegateBridge __Hotfix0_ShowPVPItems;

	private static DelegateBridge __Hotfix0_RefreshResLabel;

	private static DelegateBridge __Hotfix0_SelectTab;

	private static DelegateBridge __Hotfix0_CheckEmptyShip;

	private static DelegateBridge __Hotfix0_refrshList;

	private static DelegateBridge __Hotfix0_refreshResNum;

	private static DelegateBridge __Hotfix0_RefreshNormalItems;

	private static DelegateBridge __Hotfix0_RefreshNormalShop;

	private static DelegateBridge __Hotfix0_RefreshShop;

	private static DelegateBridge __Hotfix0_SetRefreshButton;

	private static DelegateBridge __Hotfix0_RefreshMazeItems;

	private static DelegateBridge __Hotfix0_RefreshPVPItems;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_isPayShipOpenByFreeShip;

	private static DelegateBridge __Hotfix0_InitRefreshPop;

	private static DelegateBridge __Hotfix0_initRelicsGiftBox;

	private static DelegateBridge __Hotfix0_freshRelicsGiftBox;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Update()
	{
	}

	private void closeWindow()
	{
	}

	private long getEndTime()
	{
		return 0L;
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void refreshPayShipCtrl()
	{
	}

	private void refresh_text_drive()
	{
	}

	private void android_escape()
	{
	}

	private void ShowItems()
	{
	}

	private void LoadPaidItems()
	{
	}

	private void LoadNormalItems()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void showItemBG()
	{
	}

	private void ClearItems()
	{
	}

	private void DetoryChilds(Transform tar)
	{
	}

	private void ShowNormalItems()
	{
	}

	private void ShowPayItems()
	{
	}

	private void ShowMazeItems()
	{
	}

	private void ShowPVPItems()
	{
	}

	private void RefreshResLabel()
	{
	}

	private void SelectTab(int tab)
	{
	}

	private bool CheckEmptyShip(int tab)
	{
		return false;
	}

	private void refrshList()
	{
	}

	private void refreshResNum(int equipid)
	{
	}

	private void RefreshNormalItems()
	{
	}

	private void RefreshNormalShop()
	{
	}

	private void RefreshShop()
	{
	}

	private void SetRefreshButton()
	{
	}

	private void RefreshMazeItems()
	{
	}

	private void RefreshPVPItems()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}

	private bool isPayShipOpenByFreeShip()
	{
		return false;
	}

	public void InitRefreshPop()
	{
	}

	public void initRelicsGiftBox()
	{
	}

	private void freshRelicsGiftBox()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}
}
