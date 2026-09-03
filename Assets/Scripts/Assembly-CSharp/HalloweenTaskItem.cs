using UIKit;
using UnityEngine;

public class HalloweenTaskItem : UITableViewCell
{
	[SerializeField]
	private DxxText taskName;

	[SerializeField]
	private DxxText taskProgress;

	[SerializeField]
	private DxxText btnName;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private GameObject claimedStatus;

	[SerializeField]
	private Transform parent;

	private bool isInit;

	private LocalUnityObjctPool propPool;

	private HalloweenTaskItemData itemData;

	private HalloweenActManager HalloweenActManager => null;

	private HalloweenTaskData TaskData => null;

	private void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	public void Refresh(HalloweenTaskItemData itemData)
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
