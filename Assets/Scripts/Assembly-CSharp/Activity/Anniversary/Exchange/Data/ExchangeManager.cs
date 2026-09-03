using System;
using GameProtocol;
using XLua;

namespace Activity.Anniversary.Exchange.Data
{
	public class ExchangeManager : CInstance<ExchangeManager>
	{
		public const float ScrollMoveDuration = 0.5f;

		public const float ScrollNormalLastSpacing = 260f;

		public const float ScrollNormalSpacing = 77f;

		public const float ScrollExtraSpacing = 0f;

		public const float ScrollNormalHeight = 500f;

		public const float ScrollExtraHeight = 160f;

		public const float ProgressMaxOffset = 35f;

		public const float OriginWaveScale = 0f;

		public const float WaveScale = 20f;

		public const float WaveMin = -87f;

		public const float WaveMax = 91f;

		public const string ThemeBg = "Anniversary_Exchange_RewardBg_";

		public const string ThemeSubBg = "Anniversary_Exchange_RewardSubBg_";

		public const string ThemeLight = "Anniversary_Exchange_RewardBg_Ligint_";

		public const string ThemeStar = "Anniversary_Exchange_RewardBg_Star_";

		public const string ThemeSphereBg = "Anniversary_Exchange_SphereBg_";

		public const string WaveSilver = "#0058C4";

		public const string WaveGold = "#9E00C6";

		public const int ExchangeItemA = 33024;

		private static DelegateBridge __Hotfix0_get_ExchangeData;

		private static DelegateBridge __Hotfix0_set_ExchangeData;

		private static DelegateBridge __Hotfix0_get_ExchangeRewardData;

		private static DelegateBridge __Hotfix0_set_ExchangeRewardData;

		private static DelegateBridge __Hotfix0_get_ScrollNormalCount;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Clear;

		private static DelegateBridge __Hotfix0_RequestServerData;

		private static DelegateBridge __Hotfix0_RequestReward;

		private static DelegateBridge __Hotfix0_GetExchangeData;

		private static DelegateBridge __Hotfix0_GetExchangeRewardData;

		private static DelegateBridge __Hotfix0_GetRewardProgress;

		private static DelegateBridge __Hotfix0_UpdateCurrency;

		private static DelegateBridge __Hotfix0_GetRewardCurrencyCount;

		private static DelegateBridge __Hotfix0_HaveRedNode;

		private static DelegateBridge __Hotfix0_HaveData;

		private static DelegateBridge _c__Hotfix0_ctor;

		private ExchangeData ExchangeData { get; set; }

		private ExchangeRewardData ExchangeRewardData { get; set; }

		public int ScrollNormalCount => 0;

		public new void Init()
		{
		}

		public new void Clear()
		{
		}

		public void RequestServerData(STActivityAnniversaryExchange exchangeData)
		{
		}

		public void RequestReward(int rewardID, Action<CRewardItem[]> success = null, Action failure = null)
		{
		}

		public ExchangeData GetExchangeData()
		{
			return null;
		}

		public ExchangeRewardData GetExchangeRewardData()
		{
			return null;
		}

		public int GetRewardProgress()
		{
			return 0;
		}

		public void UpdateCurrency(int count)
		{
		}

		public int GetRewardCurrencyCount(int id, bool isCalcAllLeft = false)
		{
			return 0;
		}

		public bool HaveRedNode()
		{
			return false;
		}

		public bool HaveData()
		{
			return false;
		}
	}
}
