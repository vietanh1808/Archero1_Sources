using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Vault2023ShowRewardItem : MonoBehaviour
{
	[SerializeField]
	private Image finalRewardBg;

	[SerializeField]
	private Image bannerIcon;

	[SerializeField]
	private Transform showCondParent;

	[SerializeField]
	private Vault2023ShowRewardCondItem condItem;

	[SerializeField]
	private DxxText rewardCount;

	[SerializeField]
	private PropOneEquip reward;

	[SerializeField]
	private GameObject mask;

	[SerializeField]
	private Vault2023ShowRewardItemAni rewardItemAni;

	private List<Vault2023ShowRewardCondItem> create;

	private Vault2023ShowRewardItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private bool isSpecial;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshImg;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_SetActiveStatus;

	private static DelegateBridge __Hotfix0_GetCondItemID;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	public void Refresh(Vault2023ShowRewardItemData data, bool isSpecial)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshImg()
	{
	}

	private void RefreshStatus()
	{
	}

	public void SetActiveStatus()
	{
	}

	public int GetCondItemID()
	{
		return 0;
	}
}
