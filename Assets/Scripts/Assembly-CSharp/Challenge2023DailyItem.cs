using UnityEngine;
using XLua;

public class Challenge2023DailyItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText progress;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private GameObject normalStatus;

	[SerializeField]
	private GameObject claimedStatus;

	[SerializeField]
	private DxxText clickName;

	private Challenge2023ItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private static DelegateBridge __Hotfix0_get_Christmas2023Manager;

	private static DelegateBridge __Hotfix0_get_Challenge2023Data;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_InitPool;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Christmas2023Manager Christmas2023Manager => null;

	private Challenge2023Data Challenge2023Data => null;

	private void Init()
	{
	}

	private void InitPool()
	{
	}

	public void Refresh(Challenge2023ItemData data)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
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
}
