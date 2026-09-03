using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SelectHeroUICtrl : MediatorCtrlBase
{
	private const float modelDistance = 200f;

	private const float reboundTime = 0.15f;

	private const float modelMaxScale = 120f;

	private const float modelMinScale = 100f;

	private float modelPosXMax;

	public Transform modelParent;

	public DxxText hasSelectText;

	public DxxText selectBtnText;

	public DxxText buyPriceText;

	public DxxText chapterUnLockText;

	public DxxText purchasePriceText;

	public DxxText tryPlayBtnText;

	public ButtonCtrl btnTryPlay;

	public Image priceIconImage;

	public Image btnBuyImage;

	public ButtonCtrl btnBuy;

	public ButtonCtrl btnSelect;

	public ButtonCtrl btnClose;

	public SelectCharacter_Skill copySkill;

	public Transform skillParent;

	public ButtonCtrl btnGet;

	public DxxText SkinBtnText;

	public DxxText getText;

	public GameObject copyModelParent;

	public DxxText propertyText;

	public DxxText nameText;

	public Transform modelShowParent;

	public HeroEnhanceView heroEnhanceView;

	public GameObject copyOne;

	public Transform scrollChild;

	public RectTransform scrollArea;

	public RectTransform bottomBar;

	public ButtonCtrl btnUpgrade;

	public ButtonCtrl btnUpgradeNormal;

	public ButtonCtrl btnSkin;

	public ButtonCtrl btnActivityGet;

	public DxxText Text_ActivityGet;

	public DxxText upgradeText;

	public DxxText upgradeTextNormal;

	public GridLayoutGroup heroCardRoot;

	public HeroCardOneCtrl copyCard;

	public GameObject heroCardCache;

	[SerializeField]
	private SelectHeroInfinity mInfinity;

	public HeroLevelInfoCtrl PropLevel;

	public HeroPropInfoCtrl HPInfo;

	public HeroPropInfoCtrl AtkInfo;

	public DxxText SkillTitle;

	public FitContentText SkillDesText;

	public HeroInfoTipCtrl HeroInfoTipCtrl;

	public HeroInfoTipPopCtrl PopCtrl;

	public HeroInfoTipPopCtrl skillPopCtrl;

	public GameObject discount;

	public DxxText discount_Num;

	public DxxText discount_Text;

	public DxxText old_Price;

	public DxxText new_Price;

	public RectTransform redLine;

	public FragmentInfoCtrl fragmentInfo;

	public ButtonCtrl btnHeroGet;

	public DxxText heroGetText;

	public CharStarShowItem starItem;

	[Header("单独技能 & 额外技能")]
	[SerializeField]
	private HeroExtraShowSkill extraShowSkill;

	[SerializeField]
	private ButtonCtrl skillDetailTip;

	[SerializeField]
	private GameObject singleSkill;

	[SerializeField]
	private GameObject extraSkill;

	private int curSelectIndex;

	private int curSelectSkinId;

	private int curSelectSkinIndex;

	private string heroInfoTipStr;

	private List<int> updateCharacterIndex;

	private int totalCharacterCount;

	private List<SelectCharacter_Skill> skillList;

	private PlayerCharacter_Character[] dataArray;

	private CharacterModelOneCtrl[] modelOneCtrls;

	private SelectCharacterData m_CharData;

	private bool bChangeHero;

	private bool upgrade_open;

	private float btnSelectx;

	private float textSelectx;

	public GameObject Effect_Fragment_Unlock;

	public ButtonCtrl Button_Assist;

	public DxxText Text_Assist;

	public ButtonCtrl Button_Badge;

	public DxxText Text_Badge;

	public GameObject RedDot_Badge;

	public GameObject plate_left;

	public GameObject plate_right;

	[SerializeField]
	private RedNodeCtrl upgradeRed;

	[SerializeField]
	private RedNodeCtrl heroAssistRed;

	[SerializeField]
	private GameObject heroSkinCollectRed;

	protected override void OnInit()
	{
	}

	private bool IsFragmentEnough(PlayerCharacter_Character tableData)
	{
		return false;
	}

	private void ShowFragmentInfo(PlayerCharacter_Character tableData)
	{
	}

	private void InitText()
	{
	}

	protected override void OnOpen()
	{
	}

	private static void SetBottomToTop(RectTransform dest, int gap, RectTransform src)
	{
	}

	private void UpdateHeroEnhanceView(bool bChange = true)
	{
	}

	private void OnSelectSkin(int index, PlayerCharacter_Skin data)
	{
	}

	private void OnClickSkinBtn()
	{
	}

	private void OnLoadedIcon(bool ifSuccess)
	{
	}

	private void RefreshHeroCardIcon()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	private void refresh_upgrade_open()
	{
	}

	private void RefreshDesc(CharacterModelOneCtrl one)
	{
	}

	private void UpdateUpgradeRed()
	{
	}

	public void refreshTopInfo()
	{
	}

	private void show_upgrade_button(bool value)
	{
	}

	private void RefreshBottomButton()
	{
	}

	private void update_buy_button_text()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnPointerUpClick()
	{
	}

	private void OnPointerDownClick()
	{
	}

	private void OnClickTryPlay()
	{
	}

	private void OnClickSelect()
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void OnClickBtnAssist()
	{
	}

	private void OnClickBtnBadge()
	{
	}

	private void freshRedDot()
	{
	}

	private void RefreshHeroSkinCollectRed()
	{
	}

	private void OnClickHeroGet()
	{
	}

	private void ShowGetHeroWindow(PlayerCharacter_Character tableData)
	{
	}

	private void OnClickBuy()
	{
	}

	private void OnConfirmBuy(PlayerCharacter_Character tableData)
	{
	}

	private void UpdateOne(int index, CharacterModelOneCtrl one)
	{
	}

	private void UpdateSize(int index, CharacterModelOneCtrl one)
	{
	}

	private void OnScrollEnd(int index, CharacterModelOneCtrl one)
	{
	}

	private void OnBeginDrag()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void InitHeroCard()
	{
	}

	private void UpdateHeroCardState()
	{
	}

	private void DeInitHeroCard()
	{
	}

	private void UpdateChildCallBack(int index, HeroCardOneCtrl one)
	{
	}
}
