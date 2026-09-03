using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using XLua;

public class BattleTowerDefense2023UICtrl : BattleLevelUICtrl
{
	public class TowerLvUpSuccessData
	{
		public int InstanceId;

		public int NewLevel;

		public int SkillId;
	}

	public class TowerLvUpData
	{
		public int InstanceId;

		public bool Show;
	}

	public class IndicatorData
	{
		public int WaveId;

		public List<Vector3> PosList;

		public float CountDown;

		public List<bool> HasBossList;
	}

	private const string UPDATE_NAME = "BattleTowerDefense2023UICtrl-Update";

	[SerializeField]
	private BattleTowerDefense2023UpgradeButton btnUpgrade;

	[SerializeField]
	private RectTransform btnRootTowers;

	[SerializeField]
	private RectTransform rootSnapIcons;

	[SerializeField]
	private RectTransform rtBgBtnUpgrade;

	[SerializeField]
	private RectTransform rtBtnUpgrade;

	[SerializeField]
	private BattleTowerDefense2023CreateButton[] btns;

	[SerializeField]
	private TowerDefenseSnapIconCtrl snapIconTemplate;

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

	private Tower_Defense_TDlevel config;

	private Sequence seqBg;

	private Sequence seqText;

	private Color colorBg;

	private static DelegateBridge __Hotfix0_get_configTdMax;

	private static DelegateBridge __Hotfix0_get_towerListCount;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_CheckGuide;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_onUpdate;

	private static DelegateBridge __Hotfix0_InitCreateButtons;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshTexts;

	private static DelegateBridge __Hotfix0_RefreshCreateButton;

	private static DelegateBridge __Hotfix0_SetHand;

	private static DelegateBridge __Hotfix0_OpenIndicator;

	private static DelegateBridge __Hotfix0_CloseIndicator;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnTowerLevelUpSuccess;

	private static DelegateBridge __Hotfix0_ShouldShowGuide;

	private static DelegateBridge __Hotfix0_OnLimitedByCount;

	private static DelegateBridge _c__Hotfix0_ctor;

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

	protected override void OnClose()
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void InitCreateButtons()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshTexts()
	{
	}

	private void RefreshCreateButton()
	{
	}

	private void SetHand()
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

	private void OnTowerLevelUpSuccess(TowerLvUpSuccessData data)
	{
	}

	private bool ShouldShowGuide()
	{
		return false;
	}

	public void OnLimitedByCount()
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

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
