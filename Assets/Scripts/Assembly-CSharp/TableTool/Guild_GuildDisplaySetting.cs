using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_GuildDisplaySetting : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _EmotionID;

		private ObscuredInt _Order;

		private ObscuredInt _Type;

		public int ID => 0;

		public string EmotionID => null;

		public int Order => 0;

		public int Type => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_GuildDisplaySetting Copy()
		{
			return null;
		}
	}
}
