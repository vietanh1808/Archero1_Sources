using System.Collections.Generic;
using TableTool;

namespace newplay122
{
	public class TDWeekRewardVO
	{
		public int RewardId;

		public int Layer;

		private TDWeekReward meta;

		public int Type => 0;

		public int Times => 0;

		public int NeedNum => 0;

		public int DropID => 0;

		public int ReceivedRewardCount { get; set; }

		public TDWeekRewardVO(int id, int layer, TDWeekReward meta)
		{
		}

		public virtual bool CanBeGet()
		{
			return false;
		}

		public virtual bool IsRewardBoxAvailable()
		{
			return false;
		}

		public bool HasGotReward()
		{
			return false;
		}

		public List<Drop_DropModel.DropData> GetDropDataList()
		{
			return null;
		}

		public List<string> GetRewardStr()
		{
			return null;
		}
	}
}
