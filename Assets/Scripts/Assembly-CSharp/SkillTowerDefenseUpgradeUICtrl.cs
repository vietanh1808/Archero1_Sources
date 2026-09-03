using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using XLua;

public class SkillTowerDefenseUpgradeUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtContent;

	[SerializeField]
	private DxxText txtTitleLevel;

	[SerializeField]
	private DxxText txtTitleAtk;

	[SerializeField]
	private DxxText txtPrice;

	[SerializeField]
	private DxxText txtLevel;

	[SerializeField]
	private DxxText txtLevelNext;

	[SerializeField]
	private DxxText txtAtk;

	[SerializeField]
	private DxxText txtAtkNext;

	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private DxxText[] txtSkillNames;

	[SerializeField]
	private Animator aniBg;

	[SerializeField]
	private Animator aniSkill;

	[SerializeField]
	private Animator aniLevel;

	[SerializeField]
	private Animator aniContent;

	[SerializeField]
	private ButtonCtrl[] btnSkills;

	[SerializeField]
	private GameObject[] goSelected;

	[SerializeField]
	private ChooseSkillButtonCtrl[] btnChooseSkills;

	[SerializeField]
	private ChooseSkillOneCtrl[] btnChooseSkillOnes;

	[SerializeField]
	private ChooseSkillColumnCtrl[] btnChooseSkillColumns;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnConfirm;

	[SerializeField]
	private GameObject cantclickObj;

	[SerializeField]
	private ButtonCtrl maskBtn;

	[SerializeField]
	private DxxText maskTip;

	private int level;

	protected SkillTowerDefenseUpgradeProxy proxy;

	private SkillTowerDefenseUpgradeProxy.Transfer transfer;

	private int selectedIndex;

	private EntityTD2023Base towerInstance;

	private Tower_Defense_DefenseTower config;

	private Daily_DefenseTower dailyConfig;

	private PVEStage_DefenseTower seasonConfig;

	public DxxImage img_attackArrow;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_RefreshBtnBgs;

	private static DelegateBridge __Hotfix0_OnConfirmClick;

	private static DelegateBridge __Hotfix0_OnCloseClick;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_saveSkills;

	private static DelegateBridge __Hotfix0_GetSkillList;

	private static DelegateBridge __Hotfix0_RefreshUI;

	private static DelegateBridge __Hotfix0_RefreshUIByLocalIds;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_setTxtAtkVisible;

	private static DelegateBridge __Hotfix0_OnSkillActionEnd;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_ClickMaskBtn;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	private void RefreshBtnBgs()
	{
	}

	private void OnConfirmClick()
	{
	}

	private void OnCloseClick()
	{
	}

	protected override void OnOpen()
	{
	}

	private void Refresh()
	{
	}

	private void saveSkills(List<int> list)
	{
	}

	private List<int> GetSkillList()
	{
		return null;
	}

	private void RefreshUI(List<int> list)
	{
	}

	private void RefreshUIByLocalIds(List<int> localSkillIds)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void setTxtAtkVisible(bool visible)
	{
	}

	private void OnSkillActionEnd()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void ClickMaskBtn()
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
