using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushPillarChoicePanel : MonoBehaviour
{
	[Header("通用")]
	public DxxText titleText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	[Header("已选展示区 - 第1行(x2倍率)")]
	public RectTransform row1Root;

	public Transform[] row1Slots;

	[Header("已选展示区 - 第2行(x1倍率)")]
	public RectTransform row2Root;

	public Transform[] row2Slots;

	[Header("提示文本")]
	public DxxText hintText;

	[Header("可选奖励区")]
	public RectTransform rewardContent;

	public ScrollRect rewardScrollRect;

	[Header("可选奖励子项预制体")]
	public GameObject choiceItemPrefab;

	[Header("按钮")]
	public ButtonCtrl confirmBtn;

	public ButtonCtrl clearAllBtn;

	public DxxText confirmBtnText;

	public DxxText clearAllBtnText;

	[Header("不再提醒")]
	public GameObject noRemindCheckObj;

	public Button noRemindBtn;

	public DxxText noRemindBtnText;

	public GameObject selectStatus;

	private readonly PropOneEquip[] slotEquips;

	private readonly ButtonCtrl[] slotRemoveBtns;

	private readonly DxxText[] slotRateTexts;

	private readonly List<PushPillarChoiceItem> choiceItems;

	private int selectedRewardId;

	private readonly Dictionary<int, int> pendingPlacements;

	private bool noRemind;

	private bool isInited;

	public bool IsNoRemind => false;

	public void Init()
	{
	}

	private void InitSlotRow(Transform[] slots, int startIndex)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void RestoreSelectedRewards()
	{
	}

	private void RefreshRewardGrid()
	{
	}

	private PushPillarChoiceItem CreateChoiceItem()
	{
		return null;
	}

	private void OnRewardSelected(int rewardId)
	{
	}

	private void OnRewardDoubleClick(int rewardId)
	{
	}

	private void QuickFillReward(int rewardId)
	{
	}

	private void OnSlotClicked(int slotIndex)
	{
	}

	private void OnSlotRemove(int slotIndex)
	{
	}

	private void RefreshSlots()
	{
	}

	private void PlaySlotPutEffect(int slotIndex)
	{
	}

	private Transform GetSlotTransform(int slotIndex)
	{
		return null;
	}

	private PushPillarChoiceRewardData FindRewardData(int rewardId, List<PushPillarChoiceRewardData> rewardList)
	{
		return null;
	}

	private int GetRewardUsedCount(int rewardId)
	{
		return 0;
	}

	private int GetRewardMaxCount(int rewardId)
	{
		return 0;
	}

	private void OnToggleNoRemind()
	{
	}

	private void OnClearAll()
	{
	}

	private void OnConfirm()
	{
	}

	private void OnChoicePlaceResult(bool success)
	{
	}

	private void OnBgOrCloseClick()
	{
	}

	private bool IsAllSlotsFilled()
	{
		return false;
	}

	private bool HasPendingChanges()
	{
		return false;
	}

	private void AutoSaveAndClose()
	{
	}

	private void OnAutoSaveResult(bool success)
	{
	}

	private void RefreshRateTextsVisibility()
	{
	}

	private void RefreshConfirmBtn()
	{
	}
}
