using Activity.Treasure;
using UnityEngine;
using XLua;

namespace Activity
{
	public class TreasureCoinPanel : MonoBehaviour
	{
		[SerializeField]
		private ActivityCommonUICtrl ctrl;

		[SerializeField]
		private ButtonCtrl btnBuy;

		[SerializeField]
		private ButtonCtrl btnBuyTen;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private ButtonCtrl btnBg;

		[SerializeField]
		private PropOneEquip preview;

		[SerializeField]
		private RectTransform rtGiftPackItemsRoot;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTime;

		[SerializeField]
		private DxxText txtDiamond;

		[SerializeField]
		private DxxText txtQuota;

		[SerializeField]
		private DxxText txtBuyOne;

		[SerializeField]
		private DxxText txtBuyTen;

		[SerializeField]
		private DxxText txtBtnBuy;

		[SerializeField]
		private DxxText txtBtnBuyTen;

		[SerializeField]
		private TreasureGiftPackItem itemTemplate;

		[SerializeField]
		private PropOneEquip propTemplate;

		private LocalUnityObjctPool pool;

		public StarDiamondItem starDiamondItem;

		private float time;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_OnClickBuy;

		private static DelegateBridge __Hotfix0_OnClickBuyTen;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_RefreshRegionDiamond;

		private static DelegateBridge __Hotfix0_RefreshGiftPackList;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void OnClickBuy()
		{
		}

		private void OnClickBuyTen()
		{
		}

		public void Refresh()
		{
		}

		private void RefreshRegionDiamond()
		{
		}

		private void RefreshGiftPackList()
		{
		}

		private void Update()
		{
		}
	}
}
