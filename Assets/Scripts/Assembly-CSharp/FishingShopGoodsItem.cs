using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingShopGoodsItem : MonoBehaviour
{
	[SerializeField]
	private PropOneEquip needItem;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private DxxText clickBtnName;

	[SerializeField]
	private DxxText leftExchangeCount;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private GameObject mask;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private DxxText discount;

	[SerializeField]
	private GameObject discountObj;

	[SerializeField]
	private GameObject countDownStatus;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private GameObject normalStatus;

	private long dayLeftTime;

	private bool isInit;

	private LocalUnityObjctPool pool;

	private FishingShopGoodsItemData data;

	private static DelegateBridge __Hotfix0_get_FishingManager;

	private static DelegateBridge __Hotfix0_get_IsShowCountDown;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge __Hotfix0_ClickDisable;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingManager FishingManager => null;

	private bool IsShowCountDown => false;

	private void InitObjectPool()
	{
	}

	private void Init()
	{
	}

	public void Refresh(FishingShopGoodsItemData data)
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

	public void RefreshCountDown(long dayLeftTime)
	{
	}

	private void RefreshTime(long dayLeftTime)
	{
	}

	private void Click()
	{
	}

	private void RequestReward(int count)
	{
	}

	private void ClickDisable()
	{
	}
}
