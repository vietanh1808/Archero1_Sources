using System.Collections.Generic;
using Activity.Anniversary.Exchange.Data;
using UIKit;
using UnityEngine;
using XLua;

namespace Activity.Anniversary.Exchange.UI
{
	public class AnniversaryExchangeRewardItem : UITableViewCell
	{
		[SerializeField]
		private ButtonCtrl clickBtn;

		[SerializeField]
		private GameObject haveGetStatus;

		[SerializeField]
		private GameObject canGetStatus;

		[SerializeField]
		private DxxText haveGetText;

		[SerializeField]
		private DxxText btnNameText;

		[SerializeField]
		private DxxText btnCurrencyText;

		[SerializeField]
		private DxxText currencyText;

		[SerializeField]
		private Transform itemParent;

		[SerializeField]
		private AnniversaryExchangeRewardShowItem showItem;

		[SerializeField]
		private AnniversaryExchangeTheme exchangeTheme;

		[SerializeField]
		private AnniversaryExchangeWater water;

		private List<AnniversaryExchangeRewardShowItem> createItem;

		private ExchangeRewardItemData rewardItemData;

		private static DelegateBridge __Hotfix0_get_ExchangeManager;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_RefreshBtn;

		private static DelegateBridge __Hotfix0_RefreshWater;

		private static DelegateBridge __Hotfix0_RefreshStatus;

		private static DelegateBridge __Hotfix0_RefreshReward;

		private static DelegateBridge __Hotfix0_OnClick;

		private static DelegateBridge __Hotfix0_RefreshText;

		private static DelegateBridge _c__Hotfix0_ctor;

		private ExchangeManager ExchangeManager => null;

		public void Refresh(ExchangeRewardItemData rewardItemData)
		{
		}

		private void RefreshBtn(int currencyCount)
		{
		}

		private void RefreshWater(int currencyCount)
		{
		}

		private void RefreshStatus()
		{
		}

		private void RefreshReward()
		{
		}

		private void OnClick()
		{
		}

		private void RefreshText()
		{
		}
	}
}
