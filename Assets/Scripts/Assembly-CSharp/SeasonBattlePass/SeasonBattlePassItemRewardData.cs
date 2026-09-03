using UnityEngine;

namespace SeasonBattlePass
{
	public class SeasonBattlePassItemRewardData : SeasonBattlePassItemDataBase
	{
		private SeasonBattlePassData infoData;

		public SeasonBattlePassItemRewardData(int pIndex, Vector2 pSize)
			: base(0, default)
		{
		}

		public override void SetData(SeasonBattlePassData pData)
		{
		}

		public override void Show(bool pShow)
		{
		}

		public override bool HasReward()
		{
			return false;
		}

		private bool IsGot(int pIndex)
		{
			return false;
		}

		private int GetMask(int pMask, int pIndex)
		{
			return 0;
		}

		public override bool IsGotPayItemReward()
		{
			return false;
		}
	}
}
