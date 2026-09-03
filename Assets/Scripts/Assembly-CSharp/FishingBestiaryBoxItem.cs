using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingBestiaryBoxItem : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private DxxText progress;

	[SerializeField]
	private Animation chestAni;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private ButtonCtrl rewardTipBtn;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private Transform chestObj;

	private FishingBestiaryBoxItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private static DelegateBridge __Hotfix0_get_FishingManager;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshImg;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshAni;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_ShowTip;

	private static DelegateBridge __Hotfix0_CloseTip;

	private static DelegateBridge __Hotfix0_Request;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingManager FishingManager => null;

	private void InitObjectPool()
	{
	}

	private void Init()
	{
	}

	public void Refresh(FishingBestiaryBoxItemData data)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshImg()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshAni()
	{
	}

	private void RefreshStatus()
	{
	}

	private void Click()
	{
	}

	private void ShowTip()
	{
	}

	private void CloseTip()
	{
	}

	private void Request()
	{
	}

	private void RequestReward()
	{
	}
}
