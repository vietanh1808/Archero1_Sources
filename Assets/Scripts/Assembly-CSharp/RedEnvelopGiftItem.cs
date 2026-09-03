using System;
using System.Runtime.CompilerServices;
using GameProtocol;
using UnityEngine;

public class RedEnvelopGiftItem : MonoBehaviour
{
	[SerializeField]
	private GameObject adStatus;

	[SerializeField]
	private GameObject moneyStatus;

	[SerializeField]
	private GameObject buyAllStatus;

	[SerializeField]
	private GameObject starStatus;

	[SerializeField]
	private DxxText limitBuy;

	[SerializeField]
	private DxxText buyAllName;

	[SerializeField]
	private DxxText purchaseName;

	[SerializeField]
	private DxxText starName;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private DxxText adName;

	[SerializeField]
	private GameObject adIcon;

	[SerializeField]
	private AdsController advertising;

	[SerializeField]
	private DxxText discount;

	[SerializeField]
	private GameObject discountObj;

	private ActRedEnvelopeGiftData itemData;

	private LocalUnityObjctPool pool;

	private bool isInit;

	[CompilerGenerated]
	private Action m_BuyCallBack;

	[CompilerGenerated]
	private Action m_StarBuyCallBack;

	private int startDiamond;

	public event Action BuyCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action StarBuyCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Refresh(ActRedEnvelopeGiftData itemData)
	{
	}

	private void Init()
	{
	}

	private void RefreshAds()
	{
	}

	private void InitPool()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshAdState()
	{
	}

	private void freshAdTime()
	{
	}

	private void RefreshItem()
	{
	}

	private void Click()
	{
	}

	private bool CheckBuy()
	{
		return false;
	}

	private void AdvertisingReward()
	{
	}

	private void AdvertisingSuccess()
	{
	}

	private void RequestReward()
	{
	}

	private void PurchaseReward()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}

	private void OnButtonStarBuy()
	{
	}
}
