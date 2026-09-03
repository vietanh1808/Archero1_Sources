using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotemResolveUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText titleTxt;

	[SerializeField]
	private DxxText totemNameTxt;

	[SerializeField]
	private DxxText materialTitleTxt;

	[SerializeField]
	private DxxText unSelectTipsTxt;

	[SerializeField]
	private DxxText resolveRareSelectTxt;

	[SerializeField]
	private DxxText resolveBtnTxt;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl tipsBtn;

	[SerializeField]
	private ButtonCtrl resolveBtn;

	[SerializeField]
	private ButtonCtrl selectRareBtn;

	[SerializeField]
	private DxxImage selectRareArrow;

	[SerializeField]
	private TotemItem totemItemShow;

	[SerializeField]
	private TotemItem totemItemTemplate;

	[SerializeField]
	private TotemRareSelectItem selectRareBtnTemplate;

	[SerializeField]
	private TotemAttTxtItem attTxtItemTemplate;

	[SerializeField]
	private PropOneEquip propTemplate;

	[SerializeField]
	private RectTransform totemItemParent;

	[SerializeField]
	private RectTransform materialParent;

	[SerializeField]
	private RectTransform selectRareParent;

	[SerializeField]
	private RectTransform totemAttParent;

	[SerializeField]
	private GameObject goSelectRarePanel;

	[SerializeField]
	private GameObject goTopShow;

	[SerializeField]
	private GameObject goTopUnShow;

	[SerializeField]
	private ScrollRect scrollRectTotem;

	[SerializeField]
	private ScrollRect scrollRectMat;

	private List<TotemItemData> _resolveList;

	private List<TotemItem> _totemList;

	private LocalUnityObjctPool _pool;

	private TotemItemData _crtSelectTotem;

	private TotemManager Mgr => null;

	private List<TotemItemData> TotemItemData => null;

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

	private void RefreshUI()
	{
	}

	private void RefreshTotemList()
	{
	}

	private void RefreshMaterialList()
	{
	}

	private void RefreshSelectRarePanel()
	{
	}

	private void RefreshTotemTopInfo()
	{
	}

	private void RefreshCrtTotemAtt()
	{
	}

	private void RefreshResolveBtnStatus()
	{
	}

	private void OnTotemItemClicked(TotemItemData data)
	{
	}

	private void OnBtnRareSelectedClick(int rare, bool isSelected)
	{
	}

	private void OnCloseBtnClicked()
	{
	}

	private void OnTipsBtnClicked()
	{
	}

	private void OnResolveBtnClicked()
	{
	}

	private void OnSelectRareBtnClicked()
	{
	}

	public void OnCloseSelectRarePanel()
	{
	}
}
