using System;
using TableTool;
using UnityEngine.UI;
using XLua;

public class ShopItemDiamondBoxNormal : ShopItemDiamondBoxBase, AdsRequestHelper.AdsCallback
{
	public Image Image_Ad;

	private Box_SilverNormalBox mData;

	private bool bWatchEnd;

	private static DelegateBridge __Hotfix0_OnAwake;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_get_price;

	private static DelegateBridge __Hotfix0_OnClickButtonAdOnly;

	private static DelegateBridge __Hotfix0_OnClickButtonKeyOnly;

	private static DelegateBridge __Hotfix0_OnClickButtonKeyOnlyInternal;

	private static DelegateBridge __Hotfix0_OnClickButton;

	private static DelegateBridge __Hotfix0_onClickButtonInternal;

	private static DelegateBridge __Hotfix0_send_get_box_wrapper;

	private static DelegateBridge __Hotfix0_send_get_box;

	private static DelegateBridge __Hotfix1_send_get_box;

	private static DelegateBridge __Hotfix0_send_open_box_ad;

	private static DelegateBridge __Hotfix0_send_open_box_pay;

	private static DelegateBridge __Hotfix0_send_open_box_internal;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_onRequest;

	private static DelegateBridge __Hotfix0_onLoad;

	private static DelegateBridge __Hotfix0_onFail;

	private static DelegateBridge __Hotfix0_onOpen;

	private static DelegateBridge __Hotfix0_onClose;

	private static DelegateBridge __Hotfix0_onClick;

	private static DelegateBridge __Hotfix0_onReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnAwake()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeinit()
	{
	}

	private int get_price(int opencount)
	{
		return 0;
	}

	private void OnClickButtonAdOnly()
	{
	}

	private void OnClickButtonKeyOnly()
	{
	}

	private void OnClickButtonKeyOnlyInternal()
	{
	}

	protected override void OnClickButton()
	{
	}

	private void onClickButtonInternal(int count)
	{
	}

	private void send_get_box_wrapper()
	{
	}

	private void send_get_box()
	{
	}

	private void send_get_box(Action callback)
	{
	}

	private void send_open_box_ad()
	{
	}

	private void send_open_box_pay()
	{
	}

	private void send_open_box_internal(bool forcePay)
	{
	}

	protected override void OnLanguageChange()
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

	private void _003C_003ExLuaBaseProxy_OnAwake()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnDeinit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClickButton()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnLanguageChange()
	{
	}
}
