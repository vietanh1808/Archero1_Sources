using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class PropOneEquip : PropOneBase
{
	public class Transfer
	{
		public PropType type;

		public object data;
	}

	public class CurrencyData
	{
		public int id;

		public long count;
	}

	public class RandomRefineData : CurrencyData
	{
		public int rarity;
	}

	public class EquipData
	{
		public int id;

		public int count;
	}

	public class GiftBoxData
	{
		public int id;

		public int count;
	}

	public class SkinData
	{
		public int id;

		public int days;
	}

	public class HeroData
	{
		public int id;

		public int days;
	}

	public class HeadData
	{
		public int id;
	}

	public class HeadFrameData
	{
		public int id;
	}

	public class AskData
	{
		public int id;
	}

	public class GuildBoxData
	{
		public int RedEnvelopeId { get; private set; }

		public int RedEnvelopeForCashId { get; private set; }

		public GuildBoxData((int, int) values)
		{
		}
	}

	public bool IsTextSizeUpdate;

	private bool bAlreadyGot;

	private long gold;

	protected Vector2 ImageSize;

	private Vector2 NormalBGSize;

	private Vector2 WeaponSkinBGSize;

	private Vector2 EGGSize;

	[Header("展示装备详情")]
	public int PropDescStyle;

	public GameObject Gold_Effect;

	[Header("右下角角标")]
	public Image BRIcon;

	[Header("右上角倍数")]
	public Image numPart;

	public DxxText partText;

	[Header("宝石等级")]
	public DxxText GemLevel;

	[Header("左上角圆圈")]
	public Image LTCircle;

	[Header("加速卡时间描述")]
	public GameObject Type20;

	public DxxText Text_Time;

	[Header("装备子品质")]
	public DxxImage Img_SubQua;

	public DxxText Text_SubQua;

	private Image Weapon_Image_BG;

	[Header("是否已获取")]
	public DxxImage Img_AlreadyGet;

	[Header("皮肤炫彩角标")]
	public Image Img_ColorSkinCircle;

	[Header("卡片品质")]
	public Image Image_CardQuality;

	private static readonly HashSet<int> TYPES_WITH_NO_CIRCLE;

	private GameObject dragonRarity;

	public int minCount;

	public int maxCount;

	public GameObject MaskHaveGetObj;

	private GameObject _headFrameEffect;

	private RectTransform _scrollRect;

	private static DelegateBridge __Hotfix0_OnAwake;

	private static DelegateBridge __Hotfix0_CreateWeaponBG;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_GeteCharacterSprite;

	private static DelegateBridge __Hotfix0_ChangeSpriteSize;

	private static DelegateBridge __Hotfix0_SetAlreadyGet;

	private static DelegateBridge __Hotfix0_SetAlreadyGetIcon;

	private static DelegateBridge __Hotfix0_GetMiddlePosition;

	private static DelegateBridge __Hotfix0_OnClicked;

	private static DelegateBridge __Hotfix0_clickShowPropDesc;

	private static DelegateBridge __Hotfix0_SetNewPlay120UIStyle;

	private static DelegateBridge __Hotfix0_SetNewPlay120GetRewardUIStyle;

	private static DelegateBridge __Hotfix0_setEndlessUIStyle;

	private static DelegateBridge __Hotfix0_setExchangeUIStyle;

	private static DelegateBridge __Hotfix0_freshItemUI;

	private static DelegateBridge __Hotfix0_setSlotUIStyle;

	private static DelegateBridge __Hotfix0_SetExtraTipStatus;

	private static DelegateBridge __Hotfix0_SetNumPart;

	private static DelegateBridge __Hotfix1_SetNumPart;

	private static DelegateBridge __Hotfix0_SetNumPartSailing;

	private static DelegateBridge __Hotfix0_setGiftBoxUIStyle;

	private static DelegateBridge __Hotfix0_SetItemBgByQuality;

	private static DelegateBridge __Hotfix0_HideLtCircle;

	private static DelegateBridge __Hotfix0_SetMinAndMaxTextValue;

	private static DelegateBridge __Hotfix0_setTimeCardTime;

	private static DelegateBridge __Hotfix0_setTextCountString;

	private static DelegateBridge __Hotfix1_setTextCountString;

	private static DelegateBridge __Hotfix0_InitRange;

	private static DelegateBridge __Hotfix1_InitRange;

	private static DelegateBridge __Hotfix0_HideTextValue;

	private static DelegateBridge __Hotfix0_SetGray;

	private static DelegateBridge __Hotfix0_OnlyShowIcon;

	private static DelegateBridge __Hotfix0_OnlyShowIconAndBg;

	private static DelegateBridge __Hotfix0_SetManorWorkerFragment;

	private static DelegateBridge __Hotfix0_SetColorIcon;

	private static DelegateBridge __Hotfix0_setMaskHaveGet;

	private static DelegateBridge __Hotfix0_get_HeadFrameEffect;

	private static DelegateBridge __Hotfix0_InitHeadFrame;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge _c__Hotfix0_ctor;

	public GameObject HeadFrameEffect => null;

	protected override void OnAwake()
	{
	}

	private void CreateWeaponBG()
	{
	}

	protected override void OnInit()
	{
	}

	public static Sprite GeteCharacterSprite(int id)
	{
		return null;
	}

	public void ChangeSpriteSize(float num)
	{
	}

	public virtual void SetAlreadyGet(bool alreadyget)
	{
	}

	public void SetAlreadyGetIcon(bool isGet)
	{
	}

	public Vector3 GetMiddlePosition()
	{
		return default;
	}

	protected override void OnClicked()
	{
	}

	public override void clickShowPropDesc()
	{
	}

	public void SetNewPlay120UIStyle()
	{
	}

	public void SetNewPlay120GetRewardUIStyle()
	{
	}

	public void setEndlessUIStyle()
	{
	}

	public void setExchangeUIStyle()
	{
	}

	public void freshItemUI()
	{
	}

	public void setSlotUIStyle()
	{
	}

	public void SetExtraTipStatus(bool isShow)
	{
	}

	public void SetNumPart(int num)
	{
	}

	public void SetNumPart(float num)
	{
	}

	public void SetNumPartSailing(float num)
	{
	}

	public void setGiftBoxUIStyle()
	{
	}

	public void SetItemBgByQuality(int quality)
	{
	}

	public void HideLtCircle()
	{
	}

	public void SetMinAndMaxTextValue(int pMin, int pMax)
	{
	}

	private void setTimeCardTime(LocalSave.EquipOne equipdata)
	{
	}

	public void setTextCountString(string text, Color color, bool outline)
	{
	}

	public void setTextCountString(string text)
	{
	}

	public void InitRange(string data)
	{
	}

	public void InitRange(int[] data)
	{
	}

	public void HideTextValue()
	{
	}

	public void SetGray(bool isSet)
	{
	}

	public void OnlyShowIcon()
	{
	}

	public void OnlyShowIconAndBg()
	{
	}

	public void SetManorWorkerFragment(string atlas, string iconName)
	{
	}

	public void SetColorIcon(bool isShow)
	{
	}

	public void setMaskHaveGet(bool mask)
	{
	}

	public void InitHeadFrame(Drop_DropModel.DropData data, RectTransform scrollRect)
	{
	}

	private void Update()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnAwake()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClicked()
	{
	}

	private void _003C_003ExLuaBaseProxy_clickShowPropDesc()
	{
	}
}
