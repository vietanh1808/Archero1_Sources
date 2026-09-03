using System;
using TableTool;
using UnityEngine;

public class ShopItemBoxManor : MonoBehaviour
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
	private DxxText txtKeyCount;

	[SerializeField]
	private ButtonCtrl btnFree;

	[SerializeField]
	private ButtonCtrl btnKey;

	[SerializeField]
	private ButtonCtrl btnBuyOne;

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

	public DxxText Text_Open1;

	public DxxText Text_Open11;

	public DxxText Text_Open10;

	private int secondsOfFreeBox;

	private Box_WorkerBox boxData;

	protected BoxOpenSingleProxy.Transfer mTransfer;

	private int count;

	private int priceTen => 0;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void OnBtnKeyClick()
	{
	}

	private void doOpenBoxKey()
	{
	}

	private void OnRetry(Action action)
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
