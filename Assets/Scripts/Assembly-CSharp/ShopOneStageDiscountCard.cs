using System;
using XLua;

public class ShopOneStageDiscountCard : ShopOneBase
{
	private LocalUnityObjctPool mPool;

	private ShopOneStageDiscount mOne;

	private Current_purchaseItem mItem;

	private bool m_bEnable;

	private ShopStageDiscount_TabCtrl.TabName m_emTabName;

	private Func<bool> mCheckBusy;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_Cache;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_DeInit;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnDeinit()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void UpdateNet()
	{
	}

	public void Show(bool show)
	{
	}

	private void Cache()
	{
	}

	public void Init(LocalUnityObjctPool pool, Current_purchaseItem item, bool enabled, ShopStageDiscount_TabCtrl.TabName sel, Func<bool> checkBusy)
	{
	}

	public void DeInit()
	{
	}
}
