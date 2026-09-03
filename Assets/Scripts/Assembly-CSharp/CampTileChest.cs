using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileChest : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private Transform content;

	[SerializeField]
	private GameObject bubble;

	[SerializeField]
	private ButtonCtrl maskBtn;

	[SerializeField]
	private Animation chestAni;

	private LocalUnityObjctPool propPool;

	private int rewardID;

	private List<Drop_DropModel.DropData> rewards;

	private CampTileRewardStatus rewardStatus;

	private bool isFinalReward;

	private (int, int) position;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshChestAni;

	private static DelegateBridge __Hotfix0_StartChestAni;

	private static DelegateBridge __Hotfix0_ResetChestAni;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_MaskClick;

	private static DelegateBridge __Hotfix0_ShowBubble;

	private static DelegateBridge __Hotfix0_CloseBubble;

	private static DelegateBridge __Hotfix0_GetIconStatusSprite;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(int rewardID, List<Drop_DropModel.DropData> rewards, CampTileRewardStatus rewardStatus, bool isFinalReward, (int, int) position)
	{
	}

	public void InitObjectPool()
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshChestAni()
	{
	}

	private void StartChestAni()
	{
	}

	private void ResetChestAni()
	{
	}

	private void Click()
	{
	}

	private void MaskClick()
	{
	}

	private void ShowBubble()
	{
	}

	private void CloseBubble()
	{
	}

	private Sprite GetIconStatusSprite()
	{
		return null;
	}
}
