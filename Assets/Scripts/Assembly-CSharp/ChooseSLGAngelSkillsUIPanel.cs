using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ChooseSLGAngelSkillsUIPanel : MediatorCtrlBase
{
	public GameObject cantclickObj;

	public List<DxxText> skillnameList;

	public DxxText Text_Level;

	public GameObject levelparent;

	public Animator Ani_bg;

	public Animator Ani_skill;

	public Animator Ani_level;

	public List<ButtonCtrl> skillbutton;

	public List<ChooseSkillButtonCtrl> chooseskillbutton;

	public List<ChooseSkillOneCtrl> chooseones;

	public List<ChooseSkillColumnCtrl> columns;

	public List<Image> bgImags;

	public ButtonCtrl mCloseBtn;

	public ButtonCtrl btn_ok;

	public DxxText txt_ok;

	public List<SLGSkillShell> slgSkillShells;

	public DxxText txt_slg_coins;

	[SerializeField]
	private List<FitContentText> skillDescList;

	[SerializeField]
	private ButtonCtrl maskBtn;

	[SerializeField]
	private DxxText maskTip;

	private List<int> selectedSkillIds;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_initData;

	private static DelegateBridge __Hotfix0_InitUI;

	private static DelegateBridge __Hotfix0_OnEscape;

	private static DelegateBridge __Hotfix0_closeWindow;

	private static DelegateBridge __Hotfix0_GetSkillList;

	private static DelegateBridge __Hotfix0_RefreshUI;

	private static DelegateBridge __Hotfix0_refreshTotalSLGCoins;

	private static DelegateBridge __Hotfix0_OnSkillActionEnd;

	private static DelegateBridge __Hotfix0_AniDisable;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_onClickBtnOK;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_ClickMaskBtn;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initData()
	{
	}

	private void InitUI()
	{
	}

	private void OnEscape()
	{
	}

	private void closeWindow()
	{
	}

	protected virtual List<int> GetSkillList()
	{
		return null;
	}

	protected void RefreshUI(List<int> skilllist)
	{
	}

	private void refreshTotalSLGCoins()
	{
	}

	private void OnSkillActionEnd()
	{
	}

	protected void AniDisable()
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

	private void onClickBtnOK()
	{
	}

	public override void OnLanguageChange()
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

	private object _003C_003ExLuaBaseProxy_OnGetEvent(string P0)
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
