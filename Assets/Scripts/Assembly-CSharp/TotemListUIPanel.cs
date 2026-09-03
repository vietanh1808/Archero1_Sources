using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotemListUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText titleTxt;

	[SerializeField]
	private DxxText totemNameTxt;

	[SerializeField]
	private DxxText btnEquipTxt;

	[SerializeField]
	private DxxText btnTakeOffTxt;

	[SerializeField]
	private DxxText btnEnhanceTxt;

	[SerializeField]
	private DxxText btnRefineTxt;

	[SerializeField]
	private DxxText unshowTotemTips;

	[SerializeField]
	private DxxText unshowTotemListTips;

	[SerializeField]
	private TotemItem totemItemShow;

	[SerializeField]
	private ButtonCtrl btnEquip;

	[SerializeField]
	private ButtonCtrl btnTakeOff;

	[SerializeField]
	private ButtonCtrl btnEnhance;

	[SerializeField]
	private ButtonCtrl btnRefine;

	[SerializeField]
	private ButtonCtrl btnLock;

	[SerializeField]
	private ButtonCtrl btnTips;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private DxxImage lockIcon;

	[SerializeField]
	private Transform attContent;

	[SerializeField]
	private Transform tabContent;

	[SerializeField]
	private Transform totemContent;

	[SerializeField]
	private TotemTabItem tabItemTemplate;

	[SerializeField]
	private TotemItem totemItemTemplate;

	[SerializeField]
	private TotemAttTxtItem attTxtItemTemplate;

	[SerializeField]
	private GameObject goTotemInfoShow;

	[SerializeField]
	private GameObject goTotemInfoUnShow;

	[SerializeField]
	private GameObject goTotemListShow;

	[SerializeField]
	private GameObject goTotemListUnShow;

	[SerializeField]
	private ScrollRect scrollTotemList;

	[SerializeField]
	private ScrollRect scrollTotemAtt;

	private List<TotemTabItem> _slotItemList;

	private List<TotemItem> _totemList;

	private TotemSlotItemData _crtSlotData;

	private TotemType _crtType;

	private TotemItemData _crtTotemData;

	private LocalUnityObjctPool _pool;

	private TotemManager Mgr => null;

	private List<TotemSlotItemData> SlotDataList => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void RefreshUI()
	{
	}

	private void RefreshTab()
	{
	}

	private void RefreshTotemList(TotemType totemType)
	{
	}

	private void RefreshLockStatus()
	{
	}

	private void RefreshBtnShow()
	{
	}

	private void RefreshTotemInfo()
	{
	}

	private void OnTotemSelected(TotemItemData tData)
	{
	}

	private void OnBtnTabSelected(TotemType totemType)
	{
	}

	private void OnLockBtnClicked()
	{
	}

	private void OnEquipBtnClicked()
	{
	}

	private void OnTakeOffBtnClicked()
	{
	}

	private void OnEnhanceBtnClicked()
	{
	}

	private void OnRefineBtnClicked()
	{
	}

	private void OnTipsBtnCLicked()
	{
	}

	public void OnCloseBtnClicked()
	{
	}
}
