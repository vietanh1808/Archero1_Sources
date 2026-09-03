using DG.Tweening;
using Dxx.Util;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class NewPlay125WeaponSkinUICtrl : MediatorCtrlBase
{
	public RawImage img_heroShow;

	private HeroShow heroShow;

	public ButtonCtrl btn_ok;

	public DxxText txt_ok;

	public Button OkBtn;

	public DxxText title;

	public DxxText text_skinName;

	public DxxText text_heroName;

	private SequencePool m_seqpool;

	private PlayerCharacter_Skin m_data;

	public DxxText m_textSkillAttribute;

	public DxxText m_textHeroAttr;

	public DxxImage m_imgAllHeros;

	public DxxText m_textAllHeros;

	public DxxText m_textheroatt1;

	public DxxText m_textheroatt2;

	public Transform modelParent;

	public BodyMask bodyMask;

	public ButtonCtrl btn_close;

	public DxxImage image_HeroBg;

	public DxxImage image_BgLight;

	public DxxImage image_banner;

	[SerializeField]
	private DxxText _textUnlockTips;

	private const string atlas = "newskinpreview";

	private const string skinBgPath = "heroskinbg_";

	private const string skinLightPath = "heroskinlight_";

	private const string skinBannerPath = "heroskinbanner_";

	private GameObject weaponModelParent;

	private GameObject weaponModel;

	public GameObject mEffectParent;

	private GameObject effect;

	private int weaponSkinId;

	private Equip_WeaponSkin weaponSkinMeta;

	private Tweener weaponModelParentTween;

	private int defaultWeaponSkinId => 0;

	protected override void OnInit()
	{
	}

	private void onNoWeaponSelected()
	{
	}

	private void onWeaponSkinSelected()
	{
	}

	private void closeInternal()
	{
	}

	protected override void OnOpen()
	{
	}

	private string getWeaponSkinName()
	{
		return null;
	}

	private string getWeaponSkinDesc()
	{
		return null;
	}

	public void LoadModel()
	{
	}

	public void Createmodel()
	{
	}

	private GameObject createHeroShow()
	{
		return null;
	}

	private void ShowHeroDesc()
	{
	}

	private void SetAttribute(DxxText tex, string des)
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnEscape()
	{
	}
}
