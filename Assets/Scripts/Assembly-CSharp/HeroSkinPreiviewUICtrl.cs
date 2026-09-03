using Dxx.Util;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class HeroSkinPreiviewUICtrl : MediatorCtrlBase
{
	public RawImage img_heroShow;

	private HeroShow heroShow;

	public Button OkBtn;

	public DxxText title;

	public DxxText text_skinName;

	public DxxText text_heroName;

	private SequencePool m_seqpool;

	private PlayerCharacter_Skin m_data;

	public DxxText m_textSkillAttribute;

	public DxxText m_textHeroAttr;

	public DxxImage m_imgAllHeros;

	public DxxText m_textAllHeros1;

	public DxxText m_textAllHeros2;

	public DxxText m_textheroatt1;

	public DxxText m_textheroatt2;

	public Transform modelParent;

	public BodyMask bodyMask;

	public ButtonCtrl btn_close;

	public DxxImage image_HeroBg;

	public DxxImage image_BgLight;

	public DxxImage image_banner;

	public ButtonCtrl btn_Change;

	public DxxImage icon_Change;

	public ExchangeHeroAttrItem[] attrItems;

	public DxxText txtSkinTips;

	public GameObject go_Circle;

	private const string atlas = "newskinpreview";

	private const string skinBgPath = "heroskinbg_";

	private const string skinLightPath = "heroskinlight_";

	private const string skinBannerPath = "heroskinbanner_";

	private GameObject crtModel;

	public GameObject mEffectParent;

	private GameObject effect;

	public ScrollRectBase scrollRect;

	public WeaponSkinHeroItem weaponSkinHeroItem;

	public WeaponSkinWeaponItem weaponSkinWeaponItem;

	private bool isHeroModel;

	private int curWeaponType;

	private int CurSkinId;

	private int curColorId;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void ShowHeroSkin(SkinPreviewProxy.Transfer t)
	{
	}

	public void LoadModel(PlayerCharacter_Skin data)
	{
	}

	private string GetBodyString(string value)
	{
		return null;
	}

	public void Createmodel(GameObject res, string modelId)
	{
	}

	private void createHeroModel(GameObject res)
	{
	}

	private GameObject createHeroShow(GameObject res)
	{
		return null;
	}

	private void ShowHeroDesc(PlayerCharacter_Skin data)
	{
	}

	public void ShowEffect()
	{
	}

	private void UnLoadModel(PlayerCharacter_Skin data)
	{
	}

	public void ShowWeapon()
	{
	}

	public void ShowWeaponAttributes(string[] atts)
	{
	}

	private void SetAttribute(DxxText tex, string des)
	{
	}

	public void ShowWeaponColor()
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}
}
