using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSkillUICtrl : MediatorCtrlBase
{
	public GameObject cantclickObj;

	public List<DxxText> skillnameList;

	public DxxText Text_Level;

	public DxxText Text_Content;

	public GameObject levelparent;

	public Animator Ani_bg;

	public Animator Ani_skill;

	public Animator Ani_level;

	public Animator Ani_content;

	public List<ButtonCtrl> skillbutton;

	public List<ChooseSkillButtonCtrl> chooseskillbutton;

	public List<ChooseSkillOneCtrl> chooseones;

	public List<ChooseSkillColumnCtrl> columns;

	public ButtonCtrl mCloseBtn;

	public ButtonCtrl mRefreshBtn;

	public Text mRefreshText;

	public DxxText mRefreshTips;

	[SerializeField]
	private List<Image> skillBg;

	[SerializeField]
	private ButtonCtrl maskBtn;

	[SerializeField]
	private DxxText maskTip;

	private int level;

	protected ChooseSkillProxy.Transfer mTransfer;

	public bool showRefreshButtonOnce;

	protected virtual bool IsShowJumpSkillBtn => false;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void OnEscape()
	{
	}

	protected virtual List<int> GetSkillList()
	{
		return null;
	}

	protected void RefreshUI(List<int> skilllist)
	{
	}

	private List<int> GetSkill9()
	{
		return null;
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

	public override void OnLanguageChange()
	{
	}

	protected virtual void ChangeJumpSkillBtnStatus(bool isActive)
	{
	}

	private void ClickMaskBtn()
	{
	}
}
