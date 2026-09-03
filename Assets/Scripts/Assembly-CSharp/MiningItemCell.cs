using System;
using Spine.Unity;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

public class MiningItemCell : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public MiningBlockShowData data;

	public GameObject goContent;

	public GameObject goMask;

	public DxxImage Image_Cell;

	public DxxImage Image_Reward;

	public DxxImage Image_Selected;

	public DxxImage Image_Smash;

	public DxxText Text_RewardCount;

	public DxxText Text_TreasureCenter;

	public MiningRewardType crtRewardType;

	public PropOneEquip propItem;

	public Slider Hp_Slider;

	public Slider BoxHp_Slider;

	public Button Btn_Cell;

	public SkeletonGraphic Blast;

	public SkeletonGraphic Treasurechest;

	public SkeletonGraphic Mattock;

	public SkeletonGraphic Shater;

	public SkeletonGraphic Gophers;

	public SkeletonGraphic BigBox;

	public GameObject go_BigBox;

	public GameObject go_BigBoxMask;

	public RectTransform rect_BigBoxSoil;

	private const string Atlas = "mining";

	private float[] randomAngle;

	private int rewardCount;

	private Action bigBoxAction;

	private Func<uint, bool> _checkRelicEffectPosIndexCallback;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_SetCheckRelicEffectPosIndexCallback;

	private static DelegateBridge __Hotfix0_InitCell;

	private static DelegateBridge __Hotfix0_RefreshBigBoxState;

	private static DelegateBridge __Hotfix0_RefreshHp;

	private static DelegateBridge __Hotfix0_RefreshTreasureChest;

	private static DelegateBridge __Hotfix0_PlayTreasureAni;

	private static DelegateBridge __Hotfix0_RefreshGophers;

	private static DelegateBridge __Hotfix0_RefreshData;

	private static DelegateBridge __Hotfix0_PlayBigBoxItemAction;

	private static DelegateBridge __Hotfix0_RefreshMask;

	private static DelegateBridge __Hotfix0_RefreshState;

	private static DelegateBridge __Hotfix0_RefreshSelectState;

	private static DelegateBridge __Hotfix0_PlayBlastAni;

	private static DelegateBridge __Hotfix0_PlayMattockAni;

	private static DelegateBridge __Hotfix0_PlayShaterAni;

	private static DelegateBridge __Hotfix0_OnButtoncCellClick;

	private static DelegateBridge __Hotfix0_PropFly;

	private static DelegateBridge __Hotfix0_SetSelectIcon;

	private static DelegateBridge __Hotfix0_OnAniStart;

	private static DelegateBridge __Hotfix0_OnAniEnd;

	private static DelegateBridge __Hotfix0_OnBlastAniStart;

	private static DelegateBridge __Hotfix0_OnBlastAniEnd;

	private static DelegateBridge __Hotfix0_OnPointerEnter;

	private static DelegateBridge __Hotfix0_OnPointerExit;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public void Init(MiningBlockShowData mdata, Action bAction = null)
	{
	}

	public void SetCheckRelicEffectPosIndexCallback(Func<uint, bool> callback)
	{
	}

	public void InitCell()
	{
	}

	public void RefreshBigBoxState()
	{
	}

	public void RefreshHp()
	{
	}

	public void RefreshTreasureChest()
	{
	}

	public void PlayTreasureAni()
	{
	}

	public void RefreshGophers()
	{
	}

	public void RefreshData(MiningBlockShowData bData)
	{
	}

	public void PlayBigBoxItemAction()
	{
	}

	public void RefreshMask()
	{
	}

	public void RefreshState()
	{
	}

	public void RefreshSelectState(bool isSelect)
	{
	}

	public void PlayBlastAni()
	{
	}

	public void PlayMattockAni()
	{
	}

	public void PlayShaterAni()
	{
	}

	public void OnButtoncCellClick()
	{
	}

	public void PropFly()
	{
	}

	public void SetSelectIcon(string iconName)
	{
	}

	public void OnAniStart()
	{
	}

	public void OnAniEnd()
	{
	}

	public void OnBlastAniStart()
	{
	}

	public void OnBlastAniEnd()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
