using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpSlider : MonoBehaviour
{
	public Transform sphereFlashTrans;

	public DxxImage sphereFlashIcon;

	private Transform mTransform;

	private GameObject child;

	public DxxText Text_HP;

	public Transform Image_Fg;

	public Transform Image_Fg_Reduce;

	public Transform Image_Fg_Blue;

	public Transform Image_Fg_Gray;

	public Transform Image_Fg_SSEquip;

	public Transform Image_Fg_Rola;

	public Transform Image_Fg_RockDragonShield;

	public Transform Image_Fg_ForestDragonShield;

	public Transform Image_Fg_LightingShield;

	public Transform Image_Fg_Phoenix;

	public RectTransform Image_Bg;

	public Image Line;

	public Transform LineParent;

	public GameObject ArthurParent;

	public RectTransform Arthur_Bg;

	public RectTransform Arthur_MPFG;

	public GameObject AthenaParent;

	public RectTransform Athena_Bg;

	public RectTransform Athena_MPFG;

	public GameObject[] Flashes;

	public GameObject TigerParent;

	public RectTransform Tiger_Bg;

	public RectTransform Tiger_MPFG;

	public GameObject WukongDemonParent;

	public RectTransform WukongDemon_Bg;

	public RectTransform WukongDemon_MPFG;

	public GameObject WukongDemon_MPFG_Fx;

	public GameObject EnergyParent;

	public RectTransform Energy_Bg;

	public RectTransform Image_MPFG;

	public RectTransform Image_MP_Reduce;

	public Transform EnergyLineParent;

	public GameObject ChargeParent;

	public RectTransform Charge_Bg;

	public RectTransform Image_Charge_MPFG;

	public RectTransform Image_Charge_MP_Reduce;

	public Transform ChargeLineParent;

	public GameObject ChargeSuperEffect;

	public GameObject AngerParent;

	public RectTransform Anger_Bg;

	public RectTransform Image_Anger_MPFG;

	public RectTransform Image_Anger_MP_Reduce;

	public Transform AngerLineParent;

	public GameObject BoxingChargeParent;

	public RectTransform BoxingCharge_Bg;

	public RectTransform Image_BoxingCharge_MPFG;

	public RectTransform Image_BoxingCharge_MP_Reduce;

	public Transform BoxingChargeLineParent;

	public GameObject FlashParent;

	public RectTransform Flash_Bg;

	public RectTransform Image_Flash_MPFG;

	public RectTransform Image_Flash_MP_Reduce;

	public Transform FlashLineParent;

	public GameObject StormEnergyParent;

	public RectTransform StormEnergy_Bg;

	public RectTransform Image_StormEnergy_MPFG;

	public RectTransform Image_StormEnergy_MP_Reduce;

	public Transform StormEnergyLineParent;

	protected EntityBase entity;

	private bool bReducingHP;

	protected float minReduceScale;

	private float reducesHP;

	private bool bReducingMP;

	private float reducesMP;

	private bool bUpdateLine;

	private float bReducingHP_PosX;

	private Color LineColor;

	private const int LineFrame = 8;

	private int LineIndex;

	private RectTransform HP_Parent;

	private RectTransform HP_BG;

	private RectTransform HP_FG_Reduce;

	private RectTransform HP_FG;

	private RectTransform HP_FG_Blue;

	private RectTransform HP_FG_RockDragonShield;

	private RectTransform HP_FG_ForestDragonShield;

	private RectTransform HP_FG_LightingShield;

	private float FG_Width;

	private float maxHP;

	private long mPerHP;

	private const float perHPWidth = 30f;

	private List<Image> mHPLineList;

	private Queue<Image> mHPLineCacheList;

	private List<Image> mEnergyLineList;

	private List<Image> mChargeLineList;

	private List<Image> mAngerLineList;

	private List<Image> mStormEnergyLineList;

	private List<Image> mBoxingChargeLineList;

	private List<Image> mFlashLineList;

	[SerializeField]
	private Transform mBulletParent;

	[SerializeField]
	private Image mBulletIconCopyOne;

	private LocalUnityObjctPool mBulletPool;

	[SerializeField]
	private Transform mSakuraParent;

	[SerializeField]
	private Image mSakuraIconCopyOne;

	private LocalUnityObjctPool mSakuraPool;

	[SerializeField]
	private GameObject m_Shield;

	[SerializeField]
	private DxxText m_ShieldText;

	[SerializeField]
	private GameObject goLeftIcons;

	private Artifact302Shield artifact302Shield;

	private Artifact302ShieldBloodPar artifact302ShieldBloodPar;

	[SerializeField]
	private GameObject m_MonkeyHair;

	private Image Arthur_MPFG_Sprite;

	private Color ArthurBlue;

	private Image Athena_MPFG_Sprite;

	private Color AthenaBlue;

	private Image Tiger_MPFG_Sprite;

	private Color TigerColor;

	private int ShowHPCount;

	private float m_fBoxingCharge;

	private float m_fFlash;

	[SerializeField]
	private GameObject mObjAngelOfJudgment;

	[SerializeField]
	private Image mImgAngelOfJudgment;

	[SerializeField]
	private Animator mAniAngelOfJJudgment;

	[SerializeField]
	private GameObject mGoDemonShieldShild;

	[SerializeField]
	private ParticleSystem mDemonShieldParticleSystem;

	private void DeInitBullet()
	{
	}

	private void InitBullet()
	{
	}

	public void UpdateBullet(int cnt)
	{
	}

	private void DeInitSakura()
	{
	}

	private void InitSakura()
	{
	}

	public void UpdateSakura(int cnt)
	{
	}

	public void UpdateShield(int cnt)
	{
	}

	public void UpdateArtifact302ShieldSelf()
	{
	}

	public void UpdateArtifact302Shield(int num)
	{
	}

	private void UpdateArtifact302BloodParScale()
	{
	}

	public void UpdateArtifactStatusBlood()
	{
	}

	public void UpdatePhoenixShield()
	{
	}

	public void UpdateMonekyHair(int cnt)
	{
	}

	private void Awake()
	{
	}

	private void Update1()
	{
	}

	private void LateUpdate()
	{
	}

	protected virtual void OnLateUpdate()
	{
	}

	public void UpdateArthur(float cur, float max)
	{
	}

	public void UpdateAthena(float cur, float max, int layerCount)
	{
	}

	public void UpdateTiger(float cur, float max)
	{
	}

	public void UpdateWukongDemon(float cur, float max)
	{
	}

	public void UpdateEnergy()
	{
	}

	public void UpdateCharge()
	{
	}

	public void ShowChargeEffect(bool show)
	{
	}

	public void UpdateAnger()
	{
	}

	public void UpdateHP()
	{
	}

	private void CheckShieldExist()
	{
	}

	private void UpdateHPText()
	{
	}

	public void UpdateShield()
	{
	}

	public void UpdateRockDragonShield()
	{
	}

	public void UpdateForestDragonShield()
	{
	}

	public void UpdateLightingShield()
	{
	}

	public void UpdateWeaponSkillShield()
	{
	}

	public void UpdateSSEquipSkillShield()
	{
	}

	public void UpdateRolaSkillShield()
	{
	}

	private void OnMaxHPUpdateInternal()
	{
	}

	private void initSphereFlash()
	{
	}

	private void InitArthurUI(float width, float blackWidth)
	{
	}

	private void InitAthenaUI(float width, float blackWidth)
	{
	}

	private void InitTigerUI(float width, float blackWidth)
	{
	}

	private void InitWukongDemonUI(float width, float blackWidth)
	{
	}

	private void InitEnergyUI(float width, float blackwidth)
	{
	}

	private void InitChargeUI(float width, float blackwidth)
	{
	}

	private void InitAngerUI(float width, float blackwidth)
	{
	}

	private void OnMaxHPUpdate(long before, long after)
	{
	}

	private Image GetEnergyLine()
	{
		return null;
	}

	private Image GetChargeLine()
	{
		return null;
	}

	private Image GetAngerLine()
	{
		return null;
	}

	private void CacheEnergyLine(Image t)
	{
	}

	private Image GetHPLine()
	{
		return null;
	}

	private void CacheHPLine(Image t)
	{
	}

	public void Init(EntityBase entity, bool reset = false)
	{
	}

	private void updateIconPosByHPWidth()
	{
	}

	private void UpdateBg()
	{
	}

	private void CalPerHp()
	{
	}

	private void initEnergyLine()
	{
	}

	private int initChargeLine()
	{
		return 0;
	}

	private void initAngerLine()
	{
	}

	public void DeInit()
	{
	}

	public void ShowHP(bool show)
	{
	}

	private void LineAnimationStart()
	{
	}

	private void LineAnimation()
	{
	}

	private void LineAniationEnd()
	{
	}

	private void OnMoveStart()
	{
	}

	private void OnMoving()
	{
	}

	private void OnMoveEnd()
	{
	}

	private void InitBoxingChargeLine()
	{
	}

	private void InitBoxingChargeUI(float width, float blackwidth)
	{
	}

	public void UpdateBoxingCharge(float fBoxingCharge)
	{
	}

	private void InitFlashLine()
	{
	}

	private void InitFlashUI(float width, float blackwidth)
	{
	}

	public void UpdateFlash(float fFlash)
	{
	}

	private void InitStormEnergy(float width, float blackwidth)
	{
	}

	public void UpdateStormEnergy(int currentValue)
	{
	}

	private void InitStormEnergyLine()
	{
	}

	private Image GetStormEnergyLine()
	{
		return null;
	}

	public void ShowAngelOfJudgment(bool show)
	{
	}

	public void UpdateAngelOfJudgment(float percent)
	{
	}

	public void InitGoDemonShieldShild()
	{
	}

	public void UpdateDemonShieldShildPercent(float percent)
	{
	}

	public void UpdateSphereFlashGrids()
	{
	}
}
