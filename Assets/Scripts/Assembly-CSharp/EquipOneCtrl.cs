using System;
using DG.Tweening;
using Dxx.UI;
using UnityEngine;
using UnityEngine.UI;

public class EquipOneCtrl : ItemRender
{
	public GameObject[] typeparent;

	public DxxText Text_Count;

	public ButtonCtrl mButton;

	public DxxText mButtonText;

	public Image Image_BG;

	public Image Image_Icon;

	public Image Image_Type;

	public GameObject levelparent;

	public DxxText Text_ID;

	public DxxText Text_Level;

	public CanvasGroup mCanvasGroup;

	public RedNodeCtrl mRedCtrl;

	public Transform child;

	public GameObject wearparent;

	public Transform upparent;

	public GameObject Gold_Effect;

	private GrayColor[] mGrays;

	private EquipWearCtrl mWearCtrl;

	private bool bGray;

	private int bgquality;

	private int iconid;

	private bool bInit;

	private int mIndex;

	public LocalSave.EquipOne equipdata;

	private Tweener tweener_ani;

	private int equipid;

	[Header("物品详情展示")]
	public int PropDescStyle;

	[Header("右下角角标")]
	public Image BRIcon;

	private Vector2 ImageSize;

	[Header("宝石等级")]
	public DxxText GemLevel;

	[Header("左上角圆圈")]
	public Image LTCircle;

	[Header("加速卡时间描述")]
	public GameObject Type20;

	public DxxText Text_Time;

	[Header("铭文子品质")]
	public GameObject carvingEffect;

	[Header("装备子品质")]
	public DxxImage Img_SubQua;

	public DxxText Text_SubQua;

	[Header("道具合成详情")]
	public Slider Slider_Compose;

	public RedNodeCtrl RedNode;

	public DxxImage Img_Fragment;

	public DxxText Text_ComposeCount;

	[HideInInspector]
	public bool showCarvingEffect;

	private int isShowWeaponSkin;

	private int showWeaponColorId;

	private GameObject dragonRarity;

	protected bool goldEffectEnabled;

	public bool CanShowDragonNew { get; set; }

	private void Awake()
	{
	}

	private new void OnInit()
	{
	}

	public virtual void OnInitComplete()
	{
	}

	public void Init(LocalSave.EquipOne equip, int quality, bool isGem)
	{
	}

	public void HideSubQuaBg()
	{
	}

	public override void Init(int index, object data, Action<object> clickEvent)
	{
	}

	public override void UpdateData(object data)
	{
	}

	public void Init(LocalSave.EquipOne equip, int showWeaponSkin = 0, int weaponColorID = 0)
	{
	}

	public void Init()
	{
	}

	public void forceShowFlagS(int rarity)
	{
	}

	private void SetSubQuality()
	{
	}

	private void setTimeCardTime()
	{
	}

	public void setTextCountString(string text, Color color, bool outline)
	{
	}

	public void setTextCountString(string text)
	{
	}

	public void HideCnt()
	{
	}

	public void showIcon(bool show)
	{
	}

	public void HideDragonRarity()
	{
	}

	public void ResetIconId(int iconid)
	{
	}

	public void showBRIcon(bool show)
	{
	}

	private void miss_all_type()
	{
	}

	private void type_show(int index, bool value)
	{
	}

	public void UpdateWear()
	{
	}

	public override void UpdateWearUI()
	{
	}

	public virtual void UpdateRedShow()
	{
	}

	private void checkIfShowNew()
	{
	}

	public void hideRedPoint()
	{
	}

	public void SetRedNodeType(RedNodeType type)
	{
	}

	public void UpdateUpShow()
	{
	}

	public virtual void SetUpShow(bool value)
	{
	}

	public void SetBGShow(bool value)
	{
	}

	private void SetBGQuality(int quality, bool isGem)
	{
	}

	private void SetBGQuality(int quality)
	{
	}

	private void set_icon(int iconid)
	{
	}

	public void SetWeaponColor()
	{
	}

	public void SetCountShow(bool value)
	{
	}

	public void SetButtonEnable(bool value)
	{
	}

	private void OnClickButton()
	{
	}

	public void ShowLevel(bool value)
	{
	}

	public void ShowAniEnable(bool value)
	{
	}

	public CanvasGroup GetCanvasGroup()
	{
		return null;
	}

	public void SetGoldEffectEnabled(bool enabled)
	{
	}

	public void showCountInGuild()
	{
	}

	public void SetCustomClickEvent(Action action)
	{
	}

	public void addEffectCast()
	{
	}
}
