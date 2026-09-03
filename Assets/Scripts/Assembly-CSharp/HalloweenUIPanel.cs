using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class HalloweenUIPanel : MediatorCtrlBase
{
	public RectTransform Window;

	public DxxText Text_BottomNum;

	public DxxText Text_TicketNum;

	public DxxText Text_HammerNum;

	public DxxText Text_MFragmentNum;

	public Image Image_Hammer;

	public Image Image_Fragment;

	public DxxText Text_Title;

	public DxxText Text_Time;

	public HallCrystalUI crystalUI;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Task;

	public ButtonCtrl Button_Shop;

	public ButtonCtrl Button_Exc;

	public DxxText[] Tab_Text;

	public GameObject[] Tab_Icon;

	public GameObject GoUseKey;

	public RectTransform rtFragment;

	private LocalUnityObjctPool pool;

	public Sprite[] kvPic;

	[SerializeField]
	private HalloweenTaskUIPanel taskUIPanel;

	[SerializeField]
	private HalloweenShopUIPanel shopUIPanel;

	[SerializeField]
	private HalloweenExchangeUIPanel excUIPanel;

	[SerializeField]
	private RedNodeCtrl taskTabRed;

	[SerializeField]
	private RedNodeCtrl shopTabRed;

	[SerializeField]
	private RedNodeCtrl excTabRed;

	[SerializeField]
	private GameObject subBg;

	[SerializeField]
	private ButtonCtrl btn_OverMask;

	[SerializeField]
	private ButtonCtrl btn_QuickBuy;

	private int currentTab;

	private static DelegateBridge __Hotfix0_get_HalloweenActManager;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonCrystal;

	private static DelegateBridge __Hotfix0_onButtonTask;

	private static DelegateBridge __Hotfix0_onButtonShop;

	private static DelegateBridge __Hotfix0_OnButtonExc;

	private static DelegateBridge __Hotfix0_OnButtonOverMask;

	private static DelegateBridge __Hotfix0_OnButtonQuickBuy;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_showTabUI;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_freshTopText;

	private static DelegateBridge __Hotfix0_freshRedPoint;

	private static DelegateBridge __Hotfix0_UseKey;

	private static DelegateBridge _c__Hotfix0_ctor;

	private HalloweenActManager HalloweenActManager => null;

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

	private void onButtonClose()
	{
	}

	private void onButtonCrystal()
	{
	}

	private void onButtonTask()
	{
	}

	private void onButtonShop()
	{
	}

	private void OnButtonExc()
	{
	}

	private void OnButtonOverMask()
	{
	}

	private void OnButtonQuickBuy()
	{
	}

	private void initUI()
	{
	}

	private void showTabUI(int tab)
	{
	}

	private void freshTime()
	{
	}

	private void freshTopText()
	{
	}

	private void freshRedPoint()
	{
	}

	public void UseKey(int allCount)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private object _003C_003ExLuaBaseProxy_OnGetEvent(string P0)
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
