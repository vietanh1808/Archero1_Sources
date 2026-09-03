using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class MainUIHeroCtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Start;

	public RectTransform ButtonParent;

	public DxxText Text_Start;

	public DxxText Text_BestStage;

	public DxxText Text_BestScore;

	public DxxText Text_ChapterIndex;

	public MainUILevelItem mStageItem;

	public MainUIBattleLayerCtrl mLayerCtrl;

	public GoldTextCtrl mKeyCtrl;

	public MainUIActivityShip mShip;

	[SerializeField]
	private MainUIPveSeasonCtrl mPveSeasonCtrl;

	private int currentStage;

	private int mKeyCount;

	public EggEntranceCtrl eggEntrance;

	public MainUIBallonAdCtrl ballonAdCtrl;

	public DxxImage Icon_Sweep;

	[SerializeField]
	private GameObject m_banParent;

	[SerializeField]
	private DxxText m_textBanTitle;

	[SerializeField]
	private DxxText m_textBanCD;

	private Coroutine m_banCoroutine;

	public Button changeBtn;

	public GameObject qipao;

	public DxxText diffcultTex;

	private Coroutine qipaoTimer;

	private GameObject mDarkClouds;

	public CampEntrance campEntrance;

	public GameObject go_Hell;

	public GameObject go_Normal;

	public DxxText txt_ClickAgain;

	private Vector3 noHellPos;

	public SailingMainIcon sailIcon;

	public TradingHouseIcon tradingHouse;

	public BraveCampEntance braveCampEntance;

	public ButtonCtrl Button_Wish;

	public DxxText Text_Wish;

	public ButtonCtrl Button_Erosion;

	public Image Image_Erosion;

	public DxxText Text_ErosionTime;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_getstartbuttony;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_InitUI;

	private static DelegateBridge __Hotfix0_ShowQiPao;

	private static DelegateBridge __Hotfix0_UpdateBanState;

	private static DelegateBridge __Hotfix0_UpdatePveSeasonUI;

	private static DelegateBridge __Hotfix0_UpDateCampEntrance;

	private static DelegateBridge __Hotfix0_UpDateTradingHouseEntrance;

	private static DelegateBridge __Hotfix0_OnClickPlay;

	private static DelegateBridge __Hotfix0_playGame;

	private static DelegateBridge __Hotfix0_CheckUnlockStage;

	private static DelegateBridge __Hotfix0_UpdateLayer;

	private static DelegateBridge __Hotfix0_UpdateHellBtn;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_UpdateBest;

	private static DelegateBridge __Hotfix0_OnStageUpdate;

	private static DelegateBridge __Hotfix0_UpdateSweep;

	private static DelegateBridge __Hotfix0_get_isUnlockSweep;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_updateSailIcon;

	private static DelegateBridge __Hotfix0_updateBraveCamp;

	private static DelegateBridge _c__Hotfix0_ctor;

	private bool isUnlockSweep => false;

	protected override void OnInit()
	{
	}

	public float getstartbuttony()
	{
		return 0f;
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	public void ShowQiPao()
	{
	}

	private void UpdateBanState()
	{
	}

	private void UpdatePveSeasonUI()
	{
	}

	private void UpDateCampEntrance()
	{
	}

	private void UpDateTradingHouseEntrance()
	{
	}

	private void OnClickPlay()
	{
	}

	private void playGame()
	{
	}

	private void CheckUnlockStage()
	{
	}

	private void UpdateLayer()
	{
	}

	public void UpdateHellBtn()
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

	private void UpdateNet()
	{
	}

	private void UpdateBest()
	{
	}

	private void OnStageUpdate()
	{
	}

	public void UpdateSweep()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void updateSailIcon()
	{
	}

	private void updateBraveCamp()
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
