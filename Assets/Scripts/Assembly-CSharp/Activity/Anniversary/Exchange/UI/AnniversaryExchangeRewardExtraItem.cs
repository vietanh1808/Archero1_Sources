using System.Collections.Generic;
using Activity.Anniversary.Exchange.Data;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity.Anniversary.Exchange.UI
{
	public class AnniversaryExchangeRewardExtraItem : UITableViewCell
	{
		[SerializeField]
		private RectTransform progress;

		[SerializeField]
		private DxxText progressText;

		[SerializeField]
		private DxxText rewardTip;

		[SerializeField]
		private DxxText countDown;

		[SerializeField]
		private DxxText clickBtnName;

		[SerializeField]
		private ButtonCtrl clickBtn;

		[SerializeField]
		private ButtonCtrl showRewardBtn;

		[SerializeField]
		private AnniversaryExchangeRewardShowItem showItem;

		[SerializeField]
		private Transform itemParent;

		[SerializeField]
		private GameObject bubble;

		[SerializeField]
		private DxxText bubbleName;

		[SerializeField]
		private GridLayoutGroup bubbleGrid;

		[SerializeField]
		private ButtonCtrl tipBtn;

		[SerializeField]
		private DxxText leftCount;

		private float progressOriginWidth;

		private ExchangeRewardItemData extraRewardData;

		private List<AnniversaryExchangeRewardShowItem> createItem;

		private static DelegateBridge __Hotfix0_get_ExchangeManager;

		private static DelegateBridge __Hotfix0_get_ExchangeData;

		private static DelegateBridge __Hotfix0_get_ExchangeRewardData;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_RefreshBubble;

		private static DelegateBridge __Hotfix0_CloseBubble;

		private static DelegateBridge __Hotfix0_RefreshProgress;

		private static DelegateBridge __Hotfix0_RefreshBtn;

		private static DelegateBridge __Hotfix0_RewardClick;

		private static DelegateBridge __Hotfix0_RefreshText;

		private static DelegateBridge __Hotfix0_RefreshBubbleReward;

		private static DelegateBridge __Hotfix0_ShowRewardClick;

		private static DelegateBridge __Hotfix0_TipClick;

		private static DelegateBridge __Hotfix0_CountDown;

		private static DelegateBridge _c__Hotfix0_ctor;

		private ExchangeManager ExchangeManager => null;

		private ExchangeData ExchangeData => null;

		private ExchangeRewardData ExchangeRewardData => null;

		public void Refresh(ExchangeRewardItemData extraRewardData)
		{
		}

		public void RefreshBubble()
		{
		}

		public void CloseBubble()
		{
		}

		private void RefreshProgress()
		{
		}

		private void RefreshBtn()
		{
		}

		private void RewardClick()
		{
		}

		private void RefreshText()
		{
		}

		private void RefreshBubbleReward()
		{
		}

		private void ShowRewardClick()
		{
		}

		private void TipClick()
		{
		}

		public void CountDown(string countDownText)
		{
		}
	}
}
