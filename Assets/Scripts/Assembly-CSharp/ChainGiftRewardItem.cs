using System;
using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ChainGiftRewardItem : MonoBehaviour, IChainGiftItemAni
{
	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private GameObject statusGroup;

	[SerializeField]
	private GameObject adStatus;

	[SerializeField]
	private DxxText adText;

	[SerializeField]
	private GameObject freeStatus;

	[SerializeField]
	private DxxText freeText;

	[SerializeField]
	private GameObject moneyStatus;

	[SerializeField]
	private DxxText moneyText;

	[SerializeField]
	private CanvasGroup lockStatus;

	[SerializeField]
	private GameObject rewardStatus;

	[SerializeField]
	private ChainGiftRewardShowItem showItem;

	[SerializeField]
	private Transform showItemGroup;

	[SerializeField]
	private ChainGiftRewardBoxItem boxItem;

	[SerializeField]
	private Image rewardBg;

	[SerializeField]
	private Image rewardItemBg;

	[SerializeField]
	private Image rewardItemBottomBg;

	[SerializeField]
	private ChainGiftArrowGroup arrowGroup;

	[SerializeField]
	private AdsController advertising;

	[SerializeField]
	private GameObject adIcon;

	private List<ChainGiftRewardShowItem> items;

	private ChainGiftRewardItemData itemData;

	private int index;

	private long oldGoldCount;

	private long oldDiamondCount;

	private bool isFromOpen;

	private static DelegateBridge __Hotfix0_get_ChainGiftManager;

	private static DelegateBridge __Hotfix0_get_BuyType;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_InitAds;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshImage;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshReward;

	private static DelegateBridge __Hotfix0_SetRewardShowItemData;

	private static DelegateBridge __Hotfix0_GetRewardClick;

	private static DelegateBridge __Hotfix0_OnAdEndWrapper;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge __Hotfix0_Purchase;

	private static DelegateBridge __Hotfix0_PurchaseSuccess;

	private static DelegateBridge __Hotfix0_SendClickEvent;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshPrice;

	private static DelegateBridge __Hotfix0_RefreshClickEnable;

	private static DelegateBridge __Hotfix0_RefreshArrow;

	private static DelegateBridge __Hotfix0_GetArrowIndex;

	private static DelegateBridge __Hotfix0_GetIndex;

	private static DelegateBridge __Hotfix0_DisAppear;

	private static DelegateBridge __Hotfix0_MoveNext;

	private static DelegateBridge __Hotfix0_Appear;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ChainGiftManager ChainGiftManager => null;

	private ChainGiftBuyType BuyType => ChainGiftBuyType.None;

	public void Init()
	{
	}

	private void InitAds()
	{
	}

	public void Refresh(ChainGiftRewardItemData itemData, int index, bool isActive, bool isFromOpen)
	{
	}

	private void RefreshImage()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshReward()
	{
	}

	public void SetRewardShowItemData(ChainGiftRewardShowItem item, string data)
	{
	}

	private void GetRewardClick()
	{
	}

	private void OnAdEndWrapper()
	{
	}

	private void RequestReward()
	{
	}

	private void Purchase()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}

	private void SendClickEvent()
	{
	}

	public void OnClose()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void RefreshPrice()
	{
	}

	public void RefreshClickEnable(bool enable)
	{
	}

	private void RefreshArrow(int index, bool isActive, bool isAni)
	{
	}

	private int GetArrowIndex(int curIndex)
	{
		return 0;
	}

	public int GetIndex()
	{
		return 0;
	}

	public void DisAppear(Action callBack)
	{
	}

	public void MoveNext(Vector3 pos, Action callBack)
	{
	}

	public void Appear(Vector3 pos, Action callBack)
	{
	}
}
