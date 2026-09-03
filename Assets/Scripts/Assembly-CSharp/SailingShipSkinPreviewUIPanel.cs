using UnityEngine;

public class SailingShipSkinPreviewUIPanel : MediatorCtrlBase
{
	private enum TabType
	{
		CurrentStage = 1,
		EndStage = 2
	}

	private enum SkinShowType
	{
		PartSkin = 1,
		AllSkin = 2
	}

	public DxxText txtTitle;

	public DxxText txtCrtTabName;

	public DxxText txtEndTabName;

	public DxxText txtChangeName;

	public DxxText txtLimit;

	public DxxFitContentText attributeItem;

	public DxxText txtAttributeName;

	public DxxImage imgTabCrtSelected;

	public DxxImage imgTabEndSelected;

	public DxxImage imgMySkin;

	public DxxImage imgAllSkin;

	public ButtonCtrl tabCrtBtn;

	public ButtonCtrl tabEndBtn;

	public ButtonCtrl btnClose;

	public ButtonCtrl btnChange;

	public SailingShipOne shipOne;

	public RectTransform attParent;

	private LocalUnityObjctPool _pool;

	private int _skinID;

	private TabType _tabType;

	private SkinShowType _skinShowType;

	private SailingShipPartData _crtStageShipWithoutAllSkinData;

	private SailingShipPartData _crtStageShipWithAllSkinData;

	private SailingShipPartData _endStageShipWithoutAllSkinData;

	private SailingShipPartData _endStageShipWithAllSkinData;

	private SailingShipPartSkinItemData _crtSkinData;

	private SailingShipManager _SmMgr => null;

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

	private void InitShip(SailingShipPartData shipData)
	{
	}

	public void InitData()
	{
	}

	public void InitAttributeShow()
	{
	}

	private void InitType()
	{
	}

	public void RefreshText()
	{
	}

	public void OnBtnCloseClicked()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshShip()
	{
	}

	private void RefreshTab()
	{
	}

	private void RefreshChangeStatus()
	{
	}
}
