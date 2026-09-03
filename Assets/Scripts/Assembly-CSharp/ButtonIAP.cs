using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;

public class ButtonIAP : MonoBehaviour
{
	public class ShowData
	{
		public string productId;

		public List<Drop_DropModel.DropData> previewRewardList;

		public Func<bool> preCallback;

		public Action<CRespInAppPurchase, bool> nextCallback;

		public ShopOpenSource source;

		public bool isStar;

		public int starNum;

		public static ShowData Create(string pid, List<Drop_DropModel.DropData> list, Func<bool> c1, Action<CRespInAppPurchase, bool> c2, ShopOpenSource sos)
		{
			return null;
		}

		public static ShowData CreateStar(int star, Func<bool> c1, ShopOpenSource sos)
		{
			return null;
		}
	}

	public bool canUseStarDiamond;

	public bool canUseIAP;

	public GameObject IAPObj;

	public DxxText Text_Price;

	public GameObject StarDiamondObj;

	public DxxText Text_StarDiamond;

	public ButtonCtrl Button_Buy;

	private bool showStarMode;

	private ShowData showData;

	public void Awake()
	{
	}

	public void init(ShowData data)
	{
	}

	private void onButtonBuy()
	{
	}

	private void requestStarDiamond()
	{
	}

	private void PurchaseIAP()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}

	public void setButtonState(bool touch)
	{
	}

	private bool isShowSecond()
	{
		return false;
	}

	private bool checkBuyPre()
	{
		return false;
	}
}
