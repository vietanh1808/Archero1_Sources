using GameProtocol;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity
{
	public class ActivityBPDetailPanel : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtRewardUnlocked;

		[SerializeField]
		private DxxText txtRewardTotal;

		[SerializeField]
		private PropOneEquip template;

		[SerializeField]
		private RectTransform rtUnlock;

		[SerializeField]
		private RectTransform rtTotal;

		[SerializeField]
		private ScrollRect srUnlock;

		[SerializeField]
		private ScrollRect srTotal;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private DxxImage imgBg;

		[SerializeField]
		private DxxImage imgIcon;

		[SerializeField]
		private DxxImage imgBgRewardsUnlocked;

		[SerializeField]
		private VIPFlagItem vipItem;

		[SerializeField]
		private ActivityBPPanel panel;

		private LocalUnityObjctPool pool;

		private string productId;

		private ushort type;

		private bool isPremium;

		public StarDiamondItem starDiamondItem;

		public ButtonIAP buttonIAP;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnClickBuy;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_RefreshRewards;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_checkBuy;

		private static DelegateBridge __Hotfix0_purchaseCallback;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnClickBuy()
		{
		}

		public void Open(bool premium, ActivityBpStyle style, ActivityBPPanel bpPanel)
		{
		}

		private void RefreshRewards()
		{
		}

		private void Close()
		{
		}

		private bool checkBuy()
		{
			return false;
		}

		private void purchaseCallback(CRespInAppPurchase response, bool success)
		{
		}
	}
}
