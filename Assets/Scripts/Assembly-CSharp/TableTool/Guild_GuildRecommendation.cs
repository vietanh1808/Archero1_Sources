using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_GuildRecommendation : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Ratio;

		private ObscuredInt _Limit;

		public int ID => 0;

		public int Ratio => 0;

		public int Limit => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_GuildRecommendation Copy()
		{
			return null;
		}
	}
}
