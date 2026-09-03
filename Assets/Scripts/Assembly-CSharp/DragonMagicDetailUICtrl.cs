using System;
using DG.Tweening;
using GameProtocol;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class DragonMagicDetailUICtrl : MediatorCtrlBase
{
	public Transform window;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtLvl;

	[SerializeField]
	private DxxText txtQuality;

	[SerializeField]
	private DxxText txtBtnUpgrade;

	[SerializeField]
	private DxxText txtBtnEquip;

	[SerializeField]
	private DxxText txtTitleMaterial;

	[SerializeField]
	private DxxText txtTitleProps;

	[SerializeField]
	private DxxImage imgType;

	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private DxxImage imgRarity;

	[SerializeField]
	private DxxImage imgQualityBg;

	[SerializeField]
	private ButtonCtrl btnLeft;

	[SerializeField]
	private ButtonCtrl btnRight;

	[SerializeField]
	private ButtonCtrl btnEquip;

	[SerializeField]
	private ButtonCtrl btnUpgrade;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnBG;

	[SerializeField]
	private GameObject goMask;

	[SerializeField]
	private DragonMagicSkillDetail skillDetail;

	[SerializeField]
	private DragonMagicSkillIcon[] skillIcons;

	[SerializeField]
	private PropOneEquip[] materials;

	[SerializeField]
	private DragonMagicPropertyItem[] props;

	private int slotIndex;

	private ulong curRowId;

	private byte openType;

	private DragonMagicDetailProxy proxy;

	private SelfAttributeData selfAttritbueShow;

	public ButtonCtrl Button_KeyOne;

	public DxxText Text_KeyOne;

	private Tween tweenKeyOne;

	private bool equipped => false;

	private int dragonCount => 0;

	private LocalSave.EquipOne GetEquip()
	{
		return null;
	}

	private DragonMagic_DragonMagic GetConfig(LocalSave.EquipOne dragonEquip = null)
	{
		return null;
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void Refresh()
	{
	}

	private void refreshWindowRect(int activeCount)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void SwitchDragon(int direction)
	{
	}

	private void OnBtnUpgradeClick()
	{
	}

	private void dragonLevelUpDCError(CDragonUpgarde packet)
	{
	}

	private void PerformUpgrade(ushort newLevel, Action callback = null)
	{
	}

	private void OnBtnEquipClick()
	{
	}

	public void ShowSkillDetailPanel(int skillIndex)
	{
	}

	private void Escape()
	{
	}

	private DragonMagic_DragonUpgrade GetUpgradeConfig(LocalSave.EquipOne dragon = null)
	{
		return null;
	}

	public void SetMask(bool toShow)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private float GetDeltaPercent(LocalSave.EquipOne equipOne, SelfAttributeData selfAttributeData)
	{
		return 0f;
	}

	private void showButtonKeyOne()
	{
	}

	private void onButtonLevelUpKeyOne()
	{
	}
}
