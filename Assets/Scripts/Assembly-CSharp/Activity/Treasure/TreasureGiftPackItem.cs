using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using XLua;

namespace Activity.Treasure
{
	public class TreasureGiftPackItem : MonoBehaviour
	{
		public GameObject discount;

		public DxxText txt_discount;

		public DxxText txt_discountDesc;

		[SerializeField]
		private DxxText txtLeftCount;

		[SerializeField]
		private DxxText txtBtnAd;

		[SerializeField]
		private DxxText txtBtnCost;

		[SerializeField]
		private DxxText txtBtnAdFree;

		public ButtonIAP btnIAP;

		public ButtonCtrl btnAd;

		public ButtonCtrl btnAdFree;

		[SerializeField]
		private RectTransform rtContentRoot;

		[SerializeField]
		private RedNodeCtrl redNode;

		private List<PropOneEquip> list;

		private AdCallbackControl adCtrl;

		private TreasureIapItemData data;

		private LocalUnityObjctPool pool;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnEnable;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge __Hotfix0_OnAdEndWrapper;

		private static DelegateBridge __Hotfix0_OnAdEnd;

		private static DelegateBridge __Hotfix0_OnBtnAdFreeClick;

		private static DelegateBridge __Hotfix0_OnBtnAdClick;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_checkBuy;

		private static DelegateBridge __Hotfix0_purchaseCallback;

		private static DelegateBridge __Hotfix0_PurchaseSuccess;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnAdEndWrapper()
		{
		}

		private void OnAdEnd()
		{
		}

		private void OnBtnAdFreeClick()
		{
		}

		private void OnBtnAdClick()
		{
		}

		public void SetData(TreasureIapItemData data, LocalUnityObjctPool pool)
		{
		}

		private void Refresh()
		{
		}

		private bool checkBuy()
		{
			return false;
		}

		private void purchaseCallback(CRespInAppPurchase data, bool success)
		{
		}

		private void PurchaseSuccess(CRespInAppPurchase ciap)
		{
		}
	}
}
