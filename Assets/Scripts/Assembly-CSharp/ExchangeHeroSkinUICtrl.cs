using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ExchangeHeroSkinUICtrl : MediatorCtrlBase
{
	private const string Tag = "ExchangeHeroSkinUICtrl";

	public RawImage img_heroShow;

	private HeroShow heroShow;

	public ExchangeEnhanceView m_enhanceView;

	public ButtonCtrl m_exchangeBtn;

	public DxxText m_textPrice;

	public DxxImage m_imgBtnIcon;

	public ButtonCtrl m_selectBtn;

	public DxxText m_selectBtnText;

	public GameObject m_expiredParent;

	public DxxText m_expiredText;

	public DxxText m_exchangeBtnText;

	public ButtonCtrl m_tipsBtn;

	public ButtonCtrl m_closeBtn;

	public DxxText m_textCollection;

	public DxxText m_textCollectionCnt;

	public DxxText m_textNormalCnt;

	public DxxText m_textSpecialCnt;

	public DxxText m_textRedCnt;

	public DxxText m_textAttrTitle;

	public GameObject m_tips;

	public DxxText m_tips_1;

	public DxxText m_tips_2;

	public DxxText m_textInitialHeroTip;

	public Transform m_heroContainer;

	public GameObject m_line_1;

	public GameObject m_line_2;

	public GameObject m_line_3;

	public GameObject m_line_4;

	public DxxText m_textSkinName;

	public DxxText m_textHeroName;

	public DxxImage m_imgAllHeros;

	public DxxText m_textAllHeros;

	public DxxText m_textAlreadyWear;

	public DxxText m_textSpecialChannel;

	public GameObject m_tips2;

	public Transform m_tips2Bg;

	public ButtonCtrl m_btnCollection;

	public DxxText m_textAttrShow;

	public GameObject copyitem;

	public GameObject itemchche;

	public ButtonCtrl m_btnLockAttr;

	public Transform effectparent;

	public RectTransform topArea;

	public RectTransform bottomArea;

	[Header("英雄皮肤图鉴")]
	[SerializeField]
	private ButtonCtrl heroSkinCollectButton;

	[SerializeField]
	private ButtonCtrl heroSkinCollectAllButton;

	[SerializeField]
	private DxxText heroSkinCollectLevelText;

	[SerializeField]
	private DxxText heroSkinCollectAllText;

	[SerializeField]
	private GameObject heroSkinCollectRed;

	public RectTransform m_rect_content;

	public ExchangeHeroAttrItem[] attrItems;

	[Header("英雄大小位置")]
	public Vector3 heroScale;

	public Vector2 heroOffet;

	public Vector3 heroMaxScale;

	public Vector2 heroMaxOffet;

	public RectTransform heroPlane;

	[SerializeField]
	private ButtonCtrl upgrade;

	[SerializeField]
	private DxxText upgradeName;

	[SerializeField]
	private GameObject heroSkinUpgradeLight;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	public GameObject m_mask;

	public GameObject skinExpStartTrans;

	private float heroMaxPart;

	private float heroMinPart;

	private Vector2 heroPlanePos;

	private LocalUnityObjctPool AttrItemPool;

	private ExchangeHeroSkinProxy.Transfer mTransfer;

	private Dictionary<int, GameObject> mChangeEffects;

	private PlayerCharacter_Character m_playerCharData;

	private PlayerCharacter_Skin m_data;

	private int m_nSelectIndex;

	private bool m_bOpenFlag;

	private bool m_bShowCurrencyFlag;

	private float time;

	protected override void OnInit()
	{
	}

	private void OnConfirmExchange(bool bSure)
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	private void RefHeroPlan()
	{
	}

	private void UpdateCashCnt()
	{
	}

	private void UpdateCollection()
	{
	}

	private void RefreshHeroSkinCollectUI()
	{
	}

	private void OnCollectAllHeroSkinReward()
	{
	}

	private void UpdateHeroSkinAfterCollectReward()
	{
	}

	private void OnSelectSkin(int index, PlayerCharacter_Skin data)
	{
	}

	private void createHeroModel(GameObject o2)
	{
	}

	private GameObject createHeroShow(GameObject o2)
	{
		return null;
	}

	private string GetBodyString(string value)
	{
		return null;
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}

	public void OnClickEmpty()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	private void UpdateBtnState()
	{
	}

	private void UpdateSkinUpgrade()
	{
	}

	private string GetExpiredTime()
	{
		return null;
	}

	private string ParseExpiredTime()
	{
		return null;
	}

	private void show_effect(Character_Char data)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void OnUpdate(float delta)
	{
	}
}
