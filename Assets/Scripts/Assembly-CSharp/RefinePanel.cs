using System.Collections.Generic;
using DG.Tweening;
using TableTool;
using UnityEngine;

public class RefinePanel : MonoBehaviour, IEquipRefinePanel
{
	[SerializeField]
	private ButtonCtrl[] btnPoses;

	[SerializeField]
	private ButtonCtrl btnLeft;

	[SerializeField]
	private ButtonCtrl btnRight;

	[SerializeField]
	private ButtonCtrl btnPropRefine;

	[SerializeField]
	private ButtonCtrl btnPropSlot;

	[SerializeField]
	private ButtonCtrl btnRefine;

	[SerializeField]
	private ButtonCtrl btnInfo;

	[SerializeField]
	private DxxImage imgPosBg;

	[SerializeField]
	private DxxImage imgBtnTabPos;

	[SerializeField]
	private DxxImage imgBtnTabSlot;

	[SerializeField]
	private DxxImage[] imgBtnPosBgs;

	[SerializeField]
	private Sprite[] posBgs;

	[SerializeField]
	private Sprite[] tabPropBgs;

	[SerializeField]
	private Sprite[] posIcons;

	[SerializeField]
	private RuneSlotItem[] slots;

	[SerializeField]
	private RefineStarCtrl starCtrl;

	[SerializeField]
	private RectTransform propertyRoot;

	[SerializeField]
	private RectTransform materialRoot;

	[SerializeField]
	private RectTransform rtSlider;

	[SerializeField]
	private RectTransform rtEffect;

	[SerializeField]
	private DxxText txtPosTitle;

	[SerializeField]
	private DxxText txtBtnRefine;

	[SerializeField]
	private DxxText txtSliderValue;

	[SerializeField]
	private DxxText txtTabRefineProps;

	[SerializeField]
	private DxxText txtTabSlotProps;

	[SerializeField]
	private DxxText txtLevelMax;

	[SerializeField]
	private GameObject txtPropTemplate;

	[SerializeField]
	private GameObject materialTemplate;

	[SerializeField]
	private RefineUpgradeMaterialSelectUI materialSelectUI;

	[SerializeField]
	private RuneSelectUI runeSelectUI;

	[SerializeField]
	private GameObject goMaterialRoot;

	[SerializeField]
	private GameObject goMaxTip;

	[SerializeField]
	private EquipOneCtrl equipOne;

	[SerializeField]
	private GameObject carvingEffect;

	private int currentIndex;

	private int currentPropType;

	private LocalUnityObjctPool pool;

	private List<RefineMaterialItem> materialItems;

	private bool sliderBusy;

	private bool requestBusy;

	private bool animBusy;

	private int curProgress;

	private Sequence seq;

	private int requestPos;

	private int crtWeaponSkinID;

	private int currentPos => 0;

	private int curPosLevel => 0;

	private Equip_Refine curConfig => null;

	private Equip_Refine nextConfig => null;

	private bool materialEnough => false;

	private bool goldEnough => false;

	private Equip_Refine maxProgressConfig => null;

	private bool isZero => false;

	private bool isMax => false;

	private bool isBreakThrough => false;

	private bool busy => false;

	private void Awake()
	{
	}

	private void OnRefineClick()
	{
	}

	public void Init()
	{
	}

	public void Open(int defaultPos)
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}

	public int CurPos()
	{
		return 0;
	}

	private void SwitchPropType(int type)
	{
	}

	private void SwitchIndex(int index, bool forceRefresh = false)
	{
	}

	private void RefreshAll()
	{
	}

	private void RefreshPos()
	{
	}

	private void RefreshMaterials()
	{
	}

	private void SetMaterialBreakThrough()
	{
	}

	private void SetMaterialNormal()
	{
	}

	private void RefreshSlots()
	{
	}

	private Sequence RefreshStars(bool playBreakthrough)
	{
		return null;
	}

	private void RefreshProperties()
	{
	}

	private void ShowRefineProps()
	{
	}

	private int GetRealStar(int star)
	{
		return 0;
	}

	private int GetNextLevelSkill()
	{
		return 0;
	}

	private object GetSkillSumRefine()
	{
		return null;
	}

	private void ShowSlotProps()
	{
	}

	private static string GetPropText(Goods_goods.GoodData prop)
	{
		return null;
	}

	private static string GetSkillText(int skillId)
	{
		return null;
	}

	private void ProcessTransform(DxxText t)
	{
	}

	private void SetPropTextStyle(DxxText text, bool title)
	{
	}

	private Dictionary<string, Goods_goods.GoodData> GetPropsSumRefine()
	{
		return null;
	}

	private Dictionary<string, Goods_goods.GoodData> GetPropSumSlot(int mode)
	{
		return null;
	}

	private Dictionary<string, Goods_goods.GoodData> GetNextLevelProp()
	{
		return null;
	}

	private void RefreshProgress(bool showEffects)
	{
	}

	private int GetMaterialID()
	{
		return 0;
	}
}
