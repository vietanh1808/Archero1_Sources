using System.Collections.Generic;
using TableTool;
using XLua;

namespace Activity.Anniversary.Exchange.Data
{
	public class ExchangeRewardItemData
	{
		private static DelegateBridge __Hotfix0_get_RewardItemConfigData;

		private static DelegateBridge __Hotfix0_set_RewardItemConfigData;

		private static DelegateBridge __Hotfix0_get_ExchangeManager;

		private static DelegateBridge __Hotfix0_get_ID;

		private static DelegateBridge __Hotfix0_get_CanGetReward;

		private static DelegateBridge __Hotfix0_get_IsCurReward;

		private static DelegateBridge __Hotfix0_get_HaveGetReward;

		private static DelegateBridge __Hotfix0_get_NeedCurrencyCount;

		private static DelegateBridge __Hotfix0_get_Theme;

		private static DelegateBridge __Hotfix0_get_LeftCount;

		private static DelegateBridge __Hotfix0_GetRewardData;

		private static DelegateBridge __Hotfix0_GetRewardDataStr;

		private static DelegateBridge __Hotfix0_Create;

		private static DelegateBridge _c__Hotfix0_ctor;

		private ExchangeRewardItemConfigData RewardItemConfigData { get; set; }

		private ExchangeManager ExchangeManager => null;

		public int ID => 0;

		public bool CanGetReward => false;

		public bool IsCurReward => false;

		public bool HaveGetReward => false;

		public int NeedCurrencyCount => 0;

		public ExchangeThemeType Theme => ExchangeThemeType.None;

		public int LeftCount => 0;

		public List<Drop_DropModel.DropData> GetRewardData()
		{
			return null;
		}

		public List<string> GetRewardDataStr()
		{
			return null;
		}

		public static ExchangeRewardItemData Create(ExchangeRewardItemConfigData rewardItemConfigData)
		{
			return null;
		}
	}
}
