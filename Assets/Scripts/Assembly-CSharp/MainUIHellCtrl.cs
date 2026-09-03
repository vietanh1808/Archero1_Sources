using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class MainUIHellCtrl : MediatorCtrlBase
{
	public enum UITYPE
	{
		defaultUI = 0,
		ChristmasUI = 1
	}

	public UITYPE uitype;

	[Header("默认界面")]
	public ButtonCtrl Button_Start;

	public RectTransform ButtonParent;

	public DxxText Text_Start;

	public GoldTextCtrl mKeyCtrl;

	public Transform backWater;

	public Transform backeffect;

	public Sprite btnplay_spr;

	[SerializeField]
	private GameObject m_banParent;

	[SerializeField]
	private DxxText m_textBanTitle;

	[SerializeField]
	private DxxText m_textBanCD;

	private Coroutine m_banCoroutine;

	[Header("公用")]
	public DxxText Text_BestStage;

	public DxxText Text_BestScore;

	public DxxText Text_ChapterIndex;

	public MainUILevelItem mStageItem;

	public MainUIBattleLayerCtrl mLayerCtrl;

	[SerializeField]
	private MainUIPveSeasonCtrl mPveSeasonCtrl;

	public FireWorkCtrl FireworkNode;

	[Header("其他")]
	public EggEntranceCtrl eggEntrance;

	public MainUIBallonAdCtrl ballonAdCtrl;

	private DxxImage Icon_Sweep;

	private int currentStage;

	private int mKeyCount;

	public Button changeBtn;

	public GameObject qipao;

	public DxxText diffcultTex;

	private Coroutine qipaoTimer;

	public GameObject buttonBg;

	public CampEntrance campEntrance;

	public GameObject go_Bubble;

	public PropOneEquip propItem;

	private List<Box_ChapterHellBox> mDataList;

	public SailingMainIcon sailIcon;

	public TradingHouseIcon tradingHouse;

	public BraveCampEntance braveCampEntance;

	public ButtonCtrl Button_Wish;

	public DxxText Text_Wish;

	public ButtonCtrl Button_Erosion;

	public Image Image_Erosion;

	public DxxText Text_ErosionTime;

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

	public void UpdatePreReward()
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
}
