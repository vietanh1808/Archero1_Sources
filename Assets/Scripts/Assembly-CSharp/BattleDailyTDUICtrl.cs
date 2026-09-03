using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.Serialization;

public class BattleDailyTDUICtrl : BattleLevelUICtrl
{
	private const string UPDATE_NAME = "BattleTowerDefense2023UICtrl-Update";

	[SerializeField]
	private BattleDailyTDUpgradeButton btnUpgrade;

	[SerializeField]
	private RectTransform btnRootTowers;

	[SerializeField]
	private RectTransform rootSnapIcons;

	[SerializeField]
	private RectTransform rtBgBtnUpgrade;

	[SerializeField]
	private RectTransform rtBtnUpgrade;

	[SerializeField]
	private RectTransform rootTDBaseSnapIcon;

	[SerializeField]
	private BattleDailyTDCreateButton[] btns;

	[SerializeField]
	private TowerDefenseSnapIconCtrl snapIconTemplate;

	[SerializeField]
	private TDBaseSnapIconCtrl tbBaseSnapIconTemplate;

	[SerializeField]
	private DxxImage imgBgLimit;

	[SerializeField]
	private DxxText txtCurrency;

	[SerializeField]
	private DxxText txtTowerLimit;

	[SerializeField]
	private DxxText txtWave;

	private Dictionary<int, List<Vector3>> indicatorPos;

	private Dictionary<int, float> idToCountDown;

	private bool rightHanded;

	private LocalUnityObjctPool pool;

	private List<TowerDefenseSnapIconCtrl> snapIcons;

	private int guideStep;

	private List<int> ids;

	private GuideNoMaskCtrl guideArrow;

	private Daily_TDlevel config;

	private PVEStage_stagechapter seasonConfig;

	public RectTransform tdCoinTrans;

	[SerializeField]
	private RectTransform goldCoinRect;

	[SerializeField]
	private RectTransform topRect;

	[SerializeField]
	private RectTransform bossHpRect;

	[FormerlySerializedAs("heroItem")]
	[SerializeField]
	private TD1859HeroItem heroItem;

	private bool isOpened;

	private TDBaseSnapIconCtrl tdBaseSnapIcon;

	private Sequence seqBg;

	private Sequence seqText;

	private Color colorBg;

	private int configTdMax => 0;

	private int towerListCount => 0;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void CheckGuide()
	{
	}

	private void destroyGuideArrow()
	{
	}

	private void showGuideArrow()
	{
	}

	protected override void OnClose()
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void RefreshCreateButtons(List<int> ids)
	{
	}

	private void initHeroAssistTower()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshTexts()
	{
	}

	private int getWave()
	{
		return 0;
	}

	private void RefreshCreateButton()
	{
	}

	private void SetHand()
	{
	}

	private void OpenTDBaseIndicator()
	{
	}

	private void OpenIndicator(int id, List<Vector3> newPositions, float countDown, List<bool> hasBossList)
	{
	}

	private void CloseIndicator(int id)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void onShowBaseWarning()
	{
	}

	private void OnTowerLevelUpSuccess(BattleTowerDefense2023UICtrl.TowerLvUpSuccessData data)
	{
	}

	public void OnLimitedByCount()
	{
	}

	private void RefreshAnchored()
	{
	}
}
