using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class HeroAssistUpUIPanel : MediatorCtrlBase
{
	public class ShowData
	{
		public int leader;

		public int heroid;

		private static DelegateBridge _c__Hotfix0_ctor;
	}

	private HeroShow heroShow;

	public RawImage img_hero;

	public RectTransform ModelContainer;

	public DxxText Text_Title;

	public CharStarShowItem starItem;

	public HeroPropInfoCtrl mLevelInfoCtrl;

	public HeroPropInfoCtrl mAtkInfoCtrl;

	public HeroPropInfoCtrl mHpInfoCtrl;

	public HeroPropInfoCtrl mPerInfoCtrl;

	private int lastLevelValue;

	private int lastAtkValue;

	private int lastHpValue;

	private int lastPerValue;

	public DxxText Text_AttrTitle;

	public RectTransform RTF_Content;

	public GameObject cpAttrItem;

	public ButtonCtrl Button_Up;

	public ButtonCtrl Button_Down;

	public ButtonCtrl Button_LevelUp;

	public ButtonCtrl Button_Close;

	public DxxText Text_Up;

	public DxxText Text_Down;

	public DxxText Text_LevelUp;

	public DxxText Text_mat;

	public PropOneEquip[] propMats;

	public ButtonCtrl Button_Left;

	public ButtonCtrl Button_Right;

	private int leader;

	private int heroid;

	public Button[] button;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_initUILevelUp;

	private static DelegateBridge __Hotfix0_onButtonHeroUp;

	private static DelegateBridge __Hotfix0_onButtonHeroDown;

	private static DelegateBridge __Hotfix0_onButtonLevelUp;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_LoadModel;

	private static DelegateBridge __Hotfix0_createHeroModel;

	private static DelegateBridge __Hotfix0_createGoHeroShow;

	private static DelegateBridge __Hotfix0_showTopInfo;

	private static DelegateBridge __Hotfix0_showBasicInfo;

	private static DelegateBridge __Hotfix0_PlayLevelUp;

	private static DelegateBridge __Hotfix0_showAttrList;

	private static DelegateBridge __Hotfix0_checkAttrLevelUp;

	private static DelegateBridge __Hotfix0_showMaterial;

	private static DelegateBridge __Hotfix0_showBottomButtons;

	private static DelegateBridge __Hotfix0_onButtonRight;

	private static DelegateBridge __Hotfix0_onButtonLeft;

	private static DelegateBridge __Hotfix0_onButtonTopTips;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
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

	private void initUI()
	{
	}

	private void initUILevelUp()
	{
	}

	private void onButtonHeroUp()
	{
	}

	private void onButtonHeroDown()
	{
	}

	private void onButtonLevelUp()
	{
	}

	private void onButtonClose()
	{
	}

	private void LoadModel()
	{
	}

	private void createHeroModel(GameObject o2)
	{
	}

	private GameObject createGoHeroShow(GameObject o2)
	{
		return null;
	}

	private void showTopInfo()
	{
	}

	private void showBasicInfo()
	{
	}

	public void PlayLevelUp()
	{
	}

	private void showAttrList()
	{
	}

	private void checkAttrLevelUp()
	{
	}

	private void showMaterial()
	{
	}

	private void showBottomButtons()
	{
	}

	private void onButtonRight()
	{
	}

	private void onButtonLeft()
	{
	}

	public void onButtonTopTips(int index)
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
