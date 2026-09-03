using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class GuildActivity_BossBox_SeasonTime : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		public int ID => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public GuildActivity_BossBox_SeasonTime Copy()
		{
			return null;
		}
	}
}
