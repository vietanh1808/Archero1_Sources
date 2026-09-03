using System;
using UnityEngine;
using UnityEngine.UI;

public class ImprintInfoUICtrl : MediatorCtrlBase
{
	public class ImprintInfoData
	{
		public LocalSave.ImprintOne data;

		public bool isPreview;
	}

	public const string ImprintLevelUpAnimation = "ImprintLevelUpAnimation";

	public const string AniMoveName = "CharEquipInfoMove";

	public static Action DoMoveAni;

	public ImprintInfoAttributePart[] infoAttributeParts;

	public ImprintUnLockConsumePart unLockConsumePart;

	public ImprintLevelUpPart levelUpConsuePart;

	public DxxText titleText;

	public DxxText rareText;

	public DxxText descText;

	public DxxText maxLevelText;

	public ImprintStarCtrl starCtrl;

	public GameObject ButtonObj;

	public ImprintInfoButton unLockBtn;

	public ImprintInfoButton levelUpBtn;

	public ImprintInfoButton assemblyBtn;

	public ImprintInfoButton unAssemblyBtn;

	public ButtonCtrl closeBtn;

	public ImprintItem mImprintItem;

	public Animator animator;

	public Image mtitleBg;

	public Image mQualityBg;

	public PauseUISkillIconCtrl skillIconCtrl;

	public ImprintTips tips;

	private ImprintInfoData mImprint;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void OpenTips()
	{
	}

	public void Esc()
	{
	}

	private void OnStartLevelUp()
	{
	}

	private void OnEndLevelUp()
	{
	}

	public void OnDoMoveAni()
	{
	}

	protected override void OnClose()
	{
	}

	public void RefreshButton()
	{
	}

	public void ClosePanel()
	{
	}

	private void ClickUpgrade()
	{
	}

	private void ClickUnLock()
	{
	}

	private void ClickAssembly()
	{
	}

	private void ClickUnAssembly()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
