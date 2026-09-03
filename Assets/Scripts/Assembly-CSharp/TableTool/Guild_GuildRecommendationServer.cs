using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_GuildRecommendationServer : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Parameter;

		private ObscuredInt _GuildNum;

		public int ID => 0;

		public int Parameter => 0;

		public int GuildNum => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_GuildRecommendationServer Copy()
		{
			return null;
		}
	}
}
