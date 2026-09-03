using System.Collections.Generic;

namespace newplay122
{
	public class ServerDailyTDVO
	{
		public int stage_index;

		public int score;

		public int cur_layer;

		public int max_round;

		public Dictionary<int, int> reward_cnts;

		public int refresh_cnt;

		public long week_time;

		public long next_week_time;

		public string PrintInfo()
		{
			return null;
		}
	}
}
