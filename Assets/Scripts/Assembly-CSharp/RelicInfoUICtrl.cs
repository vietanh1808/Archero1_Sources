using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class RelicInfoUICtrl : MediatorCtrlBase
{
	public RelicAttrInfoCtrl attrInfoCtrl;

	public RelicAttrRichInfoCtrl attrRichInfoCtrl;

	public DxxText txt_attr;

	private LocalUnityObjctPool mPool;

	private RectTransform mRectTransform;

	private LocalSave.EquipOne mRelicOne;

	private RelicInfoProxy.Transfer mTransfer;

	public RectTransform iconParent;

	public RectTransform attrParent;

	[SerializeField]
	private GameObject goButtonsRoot;

	public ButtonCtrl btn_close;

	public ButtonCtrl btn_mask;

	public ButtonCtrl btn_evolution;

	public ButtonCtrl btn_star;

	public ButtonCtrl btn_forge;

	public DxxText txt_rarityInfo;

	public DxxText txt_desc;

	public ScrollRect scrollRect;

	public UILineCtrl mTitleCtrl;

	public DxxText txt_Title;

	public RelicStarCtrl starCtrl;

	public DxxImage img_Top;

	public DxxImage img_Top2;

	public RelicSetCtrl setCtrl;

	public RelicInfoButtonCtrl doEvolutionCtrl;

	public RelicInfoButtonCtrl doStarCtrl;

	public RelicInfoButtonCtrl doForgeCtrl;

	private EquipOneCtrl _relicCtrl;

	private bool isPreview;

	public RelicsExtraPopPanel extraPopPanel;

	public ButtonCtrl Button_ExtraIcon;

	public Image Image_ExtraIcon;

	public DxxText Text_ExtraNum;

	private EquipOneCtrl mRelicCtrl => null;

	public override void OnLanguageChange()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	private void refreshData()
	{
	}

	public void refreshUI()
	{
	}

	private void refreshTitle()
	{
	}

	private void refeshRelicIcon()
	{
	}

	private void refreshTxtRarityInfo()
	{
	}

	private void refreshSetInfo()
	{
	}

	private void refreshAttrInfos()
	{
	}

	private void refreshBottomBtns()
	{
	}

	private void refreshAttrByType(RelicAttrInfoCtrl.AttrType curAttrType)
	{
	}

	private void refreshRichAttrByType(RelicAttrInfoCtrl.AttrType curAttrType)
	{
	}

	private void initDatas()
	{
	}

	private void initBtns()
	{
	}

	private void initProxy()
	{
	}

	private void onClickBtnEvolution()
	{
	}

	private void onClickBtnStar()
	{
	}

	private void onClickBtnForge()
	{
	}

	private void initExtra()
	{
	}

	private void onButtonExtraIcon()
	{
	}
}
