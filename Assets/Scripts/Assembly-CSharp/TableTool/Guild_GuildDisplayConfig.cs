using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_GuildDisplayConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Resource;

		private ObscuredString _Language;

		public int ID => 0;

		public string Resource => null;

		public string Language => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_GuildDisplayConfig Copy()
		{
			return null;
		}
	}
}
