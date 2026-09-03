using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingTaskItem : UITableViewCell
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

	[SerializeField]
	private ScrollRect scroll;

	private FishingTaskItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private static DelegateBridge __Hotfix0_get_FishingManager;

	private static DelegateBridge __Hotfix0_get_FishingTaskData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_InitPool;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingManager FishingManager => null;

	private FishingTaskData FishingTaskData => null;

	private void Init()
	{
	}

	private void InitPool()
	{
	}

	public void Refresh(FishingTaskItemData data)
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
