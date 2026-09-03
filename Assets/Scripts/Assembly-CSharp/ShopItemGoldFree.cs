using UnityEngine;
using XLua;

public class ShopItemGoldFree : ShopItemGold, AdsRequestHelper.AdsCallback
{
	public DxxText buttonLabel;

	public RedNodeCtrl redNode;

	public RedNodeCtrl redNodeSkipAd;

	[SerializeField]
	private GameObject goSkip;

	[SerializeField]
	private GameObject goAd;

	public DxxText buttonLabel2;

	private bool ifWatchEnd;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_UpdateLabelStatus;

	private static DelegateBridge __Hotfix0_GetGold;

	private static DelegateBridge __Hotfix0_GetGoldTime;

	private static DelegateBridge __Hotfix0_GetDiamond;

	private static DelegateBridge __Hotfix0_onClickButtonWrapper;

	private static DelegateBridge __Hotfix0_CanSkipAd;

	private static DelegateBridge __Hotfix0_OnButtonClick;

	private static DelegateBridge __Hotfix0_UpdateFreeCount;

	private static DelegateBridge __Hotfix0_OnEnable;

	private static DelegateBridge __Hotfix0_OnDisable;

	private static DelegateBridge __Hotfix0_onRequest;

	private static DelegateBridge __Hotfix0_onLoad;

	private static DelegateBridge __Hotfix0_onFail;

	private static DelegateBridge __Hotfix0_onOpen;

	private static DelegateBridge __Hotfix0_onClose;

	private static DelegateBridge __Hotfix0_onClick;

	private static DelegateBridge __Hotfix0_onReward;

	private static DelegateBridge __Hotfix0_onRewardInternal;

	private static DelegateBridge _c__Hotfix0_ctor;

	public override void Init(int index)
	{
	}

	protected void UpdateLabelStatus()
	{
	}

	public override int GetGold()
	{
		return 0;
	}

	public override int GetGoldTime()
	{
		return 0;
	}

	public override int GetDiamond()
	{
		return 0;
	}

	private void onClickButtonWrapper()
	{
	}

	private bool CanSkipAd()
	{
		return false;
	}

	public override void OnButtonClick()
	{
	}

	public void UpdateFreeCount(int adCount)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void onRequest(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onLoad(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onFail(AdsRequestHelper.AdsDriver sender, string msg)
	{
	}

	public void onOpen(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClose(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClick(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onReward(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	private void onRewardInternal()
	{
	}

	private void _003C_003ExLuaBaseProxy_Init(int P0)
	{
	}

	private int _003C_003ExLuaBaseProxy_GetGold()
	{
		return 0;
	}

	private int _003C_003ExLuaBaseProxy_GetGoldTime()
	{
		return 0;
	}

	private int _003C_003ExLuaBaseProxy_GetDiamond()
	{
		return 0;
	}

	private void _003C_003ExLuaBaseProxy_OnButtonClick()
	{
	}
}
