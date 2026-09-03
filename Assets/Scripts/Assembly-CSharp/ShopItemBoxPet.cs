using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class ShopItemBoxPet : MonoBehaviour
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

	[Header("掉率提升")]
	[SerializeField]
	private GameObject goUpRoot;

	[Header("掉率提升")]
	[SerializeField]
	private GameObject goUpGuarantee;

	[SerializeField]
	private ButtonCtrl btnUp;

	[SerializeField]
	private RedNodeCtrl redUp;

	[SerializeField]
	private DxxText txtTimeLeft;

	private int secondsOfFreeBox;

	private Box_PetBox boxData;

	protected BoxOpenSingleProxy.Transfer mTransfer;

	private int count;

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

	private void sendRelicBoxWrapper(List<Drop_DropModel.DropData> rewards, BoxPaymentType type, int diamondCost)
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

	private void SetRedNode(bool upOpen)
	{
	}

	private void initGuide()
	{
	}

	private void finishGuide()
	{
	}

	public void RefreshBoxStateByRelics()
	{
	}
}
