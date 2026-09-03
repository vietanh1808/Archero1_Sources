using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Vault2023GameRewardItem : MonoBehaviour
{
	[SerializeField]
	private GameObject activeStatus;

	[SerializeField]
	private GameObject unActiveStatus;

	[SerializeField]
	private GameObject aniStatus;

	[SerializeField]
	private Image reward;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private Image bgImg;

	[SerializeField]
	private Vault2023GameRewardItemAni gameAni;

	[SerializeField]
	private Image aniReward;

	private Vault2023GameRewardItemData data;

	private bool isInit;

	private float originScale;

	private static DelegateBridge __Hotfix0_get_Christmas2023Manager;

	private static DelegateBridge __Hotfix0_get_Vault2023Data;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge __Hotfix0_GetRewardImg;

	private static DelegateBridge __Hotfix0_IsActive;

	private static DelegateBridge __Hotfix0_SendRefreshEvent;

	private static DelegateBridge __Hotfix0_SendRefreshEvent1;

	private static DelegateBridge __Hotfix0_SendRefreshEvent2;

	private static DelegateBridge __Hotfix0_SetActiveStatus;

	private static DelegateBridge __Hotfix0_InitAniNot;

	private static DelegateBridge __Hotfix0_InitAni;

	private static DelegateBridge __Hotfix0_ShowAniReward;

	private static DelegateBridge __Hotfix0_hideAniOnClosed;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Christmas2023Manager Christmas2023Manager => null;

	private Vault2023Data Vault2023Data => null;

	private void Init()
	{
	}

	public void Refresh(Vault2023GameRewardItemData data)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshStatus()
	{
	}

	private void Click()
	{
	}

	private void RequestReward()
	{
	}

	public Image GetRewardImg()
	{
		return null;
	}

	public bool IsActive()
	{
		return false;
	}

	private void SendRefreshEvent()
	{
	}

	private void SendRefreshEvent1()
	{
	}

	private void SendRefreshEvent2()
	{
	}

	private void SetActiveStatus(int rewardID)
	{
	}

	private void InitAniNot(int rewardID)
	{
	}

	private void InitAni(int rewardID)
	{
	}

	private void ShowAniReward()
	{
	}

	public void hideAniOnClosed()
	{
	}
}
