using UnityEngine;
using XLua;

public class LuckyWheelTaskItem : MonoBehaviour
{
	[SerializeField]
	private GameObject progressStatus;

	[SerializeField]
	private GameObject getRewardStatus;

	[SerializeField]
	private GameObject claimedStatus;

	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private DxxText progressText;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private DxxText taskName;

	[SerializeField]
	private DxxText getRewardBtnName;

	[SerializeField]
	private DxxText claimedBtnName;

	private bool isInit;

	private float progressOriginWidth;

	private LuckyWheelTaskItemData itemData;

	private static DelegateBridge __Hotfix0_get_LuckyWheelManager;

	private static DelegateBridge __Hotfix0_get_LuckyWheelData;

	private static DelegateBridge __Hotfix0_get_LuckyWheelTaskData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshProgress;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	private LuckyWheelManager LuckyWheelManager => null;

	private LuckyWheelData LuckyWheelData => null;

	private LuckyWheelTaskData LuckyWheelTaskData => null;

	private void Init()
	{
	}

	public void Refresh(LuckyWheelTaskItemData itemData)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshProgress()
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
