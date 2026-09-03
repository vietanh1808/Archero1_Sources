using System.Collections.Generic;

namespace TableTool
{
	public class Stage_Level_activitylevelModel : LocalModel<Stage_Level_activitylevel, string>
	{
		public class ActivityData
		{
			public int activityid;

			public int maxLayer;

			private string stagelevel;

			public ActivityData(int activityid)
			{
			}

			private string GetID(int id)
			{
				return null;
			}
		}

		private const string _Filename = "Stage_Level_activitylevel";

		private Dictionary<int, ActivityData> mList;

		protected override string Filename => null;

		protected override string GetBeanKey(Stage_Level_activitylevel bean)
		{
			return null;
		}

		public void Init()
		{
		}

		private void InitActivityData(int activityid)
		{
		}

		public int GetMaxLayer()
		{
			return 0;
		}

		public int GetMaxLayer(int activityid)
		{
			return 0;
		}
	}
}
