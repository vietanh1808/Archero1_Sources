using UnityEngine;

public class EquipRefineUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl[] btnTabs;

	[SerializeField]
	private DxxText[] txtBtnTabs;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private RectTransform fringeRoot;

	[SerializeField]
	private GameObject goBtnBg;

	[SerializeField]
	private Canvas[] subCanvases;

	private string[] subPanels;

	[SerializeField]
	private RectTransform[] subPanelParents;

	[SerializeField]
	private RefinePanel mRefinePanel;

	private IEquipRefinePanel[] tabs;

	private int curTabIndex;

	private IEquipRefinePanel CurPanel => null;

	protected override void OnInit()
	{
	}

	private void BindPosButtons()
	{
	}

	private void OnBtnClose()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnEscape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void SetTab(int i, int arg)
	{
	}

	private GameObject CreateTabPanel(int i, Canvas canvas = null)
	{
		return null;
	}

	private void OpenInventory()
	{
	}

	protected override void OnDeInit()
	{
	}
}
