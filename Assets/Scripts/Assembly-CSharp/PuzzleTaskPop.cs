using System;
using Activity.Anniversary;
using DG.Tweening;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class PuzzleTaskPop : MonoBehaviour
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtTitleTask;

	[SerializeField]
	private DxxText txtTitleReward;

	[SerializeField]
	private DxxText txtBtnGoTo;

	[SerializeField]
	private DxxText txtBtnClaim;

	[SerializeField]
	private DxxText txtProgress;

	[SerializeField]
	private DxxText txtDescTask;

	[SerializeField]
	private ButtonCtrl btnClaim;

	[SerializeField]
	private ButtonCtrl btnGoto;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnBg;

	[SerializeField]
	private GameObject goTick;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private RectTransform rtRewardRoot;

	[SerializeField]
	private PropOneEquip propTemplate;

	private PuzzleTaskItemData taskData;

	private PuzzleChestItemData chestData;

	private Sequence seqPropsInstantiation;

	private int index;

	private JigsawState state;

	private bool isChest;

	private Action onClose;

	private int oldLevel;

	private static DelegateBridge __Hotfix0_get_PuzzleManager;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnClickClaim;

	private static DelegateBridge __Hotfix0_ClaimSuccess;

	private static DelegateBridge __Hotfix0_OnClickGoto;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_OnEnable;

	private static DelegateBridge __Hotfix0_OnDisable;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshChest;

	private static DelegateBridge __Hotfix0_RefreshJigsaw;

	private static DelegateBridge __Hotfix0_RefreshRewards;

	private static DelegateBridge __Hotfix0_SetDynamicParts;

	private static DelegateBridge __Hotfix0_ClearRewards;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge _c__Hotfix0_ctor;

	private PuzzleManager PuzzleManager => null;

	private void Awake()
	{
	}

	public void OnClickClaim()
	{
	}

	public void ClaimSuccess(STRespActivityPuzzle response)
	{
	}

	public void OnClickGoto()
	{
	}

	public void Open(bool chest, int index, PuzzleTaskItemData taskData, PuzzleChestItemData chestData, Action onClose)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshChest()
	{
	}

	public void RefreshJigsaw()
	{
	}

	public void RefreshRewards(Drop_DropModel.DropData[] rewards)
	{
	}

	public void SetDynamicParts()
	{
	}

	private void ClearRewards()
	{
	}

	public void Close()
	{
	}
}
