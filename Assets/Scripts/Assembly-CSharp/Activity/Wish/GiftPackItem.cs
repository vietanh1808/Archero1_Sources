using System.Collections.Generic;
using UnityEngine;

namespace Activity.Wish
{
	public class GiftPackItem : MonoBehaviour
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

		[SerializeField]
		private ButtonCtrl btnCost;

		[SerializeField]
		private ButtonCtrl btnAd;

		[SerializeField]
		private ButtonCtrl btnAdFree;

		[SerializeField]
		private RectTransform rtContentRoot;

		[SerializeField]
		private RedNodeCtrl redNode;

		private List<PropOneEquip> list;

		private AdCallbackControl adCtrl;

		private PurchaseGiftItem data;

		private LocalUnityObjctPool pool;

		private void Awake()
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

		private void OnBtnCostClick()
		{
		}

		public void SetData(PurchaseGiftItem data, LocalUnityObjctPool pool)
		{
		}

		private void Refresh()
		{
		}
	}
}
