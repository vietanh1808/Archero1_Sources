using System.Collections.Generic;

namespace TableTool
{
	public class Stage_Level_activityModel : LocalModel<Stage_Level_activity, int>
	{
		public class ActivityTypeData
		{
			public int index;

			public int type;

			public Dictionary<int, int> list;

			public List<int> mIds;

			public ActivityTypeData(int type)
			{
			}

			public void Add(Stage_Level_activity value)
			{
			}

			public int GetCount(int index)
			{
				return 0;
			}

			public Stage_Level_activity GetData(int index)
			{
				return null;
			}
		}

		private const string _Filename = "Stage_Level_activity";

		private Dictionary<int, ActivityTypeData> mList;

		private List<ActivityTypeData> mList2;

		private List<Stage_Level_activity> mChallengeList;

		protected override string Filename => null;

		protected override int GetBeanKey(Stage_Level_activity bean)
		{
			return 0;
		}

		public void Init()
		{
		}

		private void InitActive()
		{
		}

		public List<ActivityTypeData> GetDifficults()
		{
			return null;
		}

		private void InitChallenge()
		{
		}

		public List<Stage_Level_activity> GetChallengeList()
		{
			return null;
		}
	}
}
