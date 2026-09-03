using System;
using TableTool;
using UnityEngine;
using XLua;

public class ShopItemDiamondBoxMix : MonoBehaviour
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtContent;

	[SerializeField]
	private DxxText txtHintOne;

	[SerializeField]
	private DxxText txtBtnFree;

	[SerializeField]
	private DxxText txtBtnBuyDesc;

	[SerializeField]
	private DxxText txtBtnBuyTenDesc;

	[SerializeField]
	private DxxText txtKeyCount;

	[SerializeField]
	private ButtonCtrl btnBuy;

	[SerializeField]
	private ButtonCtrl btnFree;

	[SerializeField]
	private ButtonCtrl btnKey;

	[SerializeField]
	private ButtonCtrl btnBuyTen;

	[SerializeField]
	private GoldTextCtrl txtGoldOne;

	[SerializeField]
	private GoldTextCtrl txtGoldTen;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	[SerializeField]
	private CountDownCtrl countDownCtrl;

	private int secondsOfFreeBox;

	private Box_BlendBox boxData;

	protected BoxOpenSingleProxy.Transfer mTransfer;

	private int count;

	private static DelegateBridge __Hotfix0_get_priceTen;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_OnBtnKeyClick;

	private static DelegateBridge __Hotfix0_OnRetry;

	private static DelegateBridge __Hotfix0_OnBtnFreeClick;

	private static DelegateBridge __Hotfix0_OnBtnBuyClick;

	private static DelegateBridge __Hotfix0_OnBtnBuyTenClick;

	private static DelegateBridge __Hotfix0_RequestBox;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_SetDynamicValues;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_UpdateBox;

	private static DelegateBridge __Hotfix0_SetRedNode;

	private static DelegateBridge __Hotfix0_RefreshBoxStateByRelics;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ushort priceTen => 0;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void OnBtnKeyClick()
	{
	}

	private void OnRetry(Action _)
	{
	}

	private void OnBtnFreeClick()
	{
	}

	private void OnBtnBuyClick()
	{
	}

	private void OnBtnBuyTenClick()
	{
	}

	private void RequestBox(BoxPaymentType type)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void SetDynamicValues()
	{
	}

	private void Update()
	{
	}

	public void UpdateUI()
	{
	}

	private void UpdateBox()
	{
	}

	private void SetRedNode()
	{
	}

	public void RefreshBoxStateByRelics()
	{
	}
}
