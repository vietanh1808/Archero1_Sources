using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_MessageEmoji : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _EmotionID;

		private ObscuredInt _Order;

		private ObscuredInt _Type;

		public int ID => 0;

		public int EmotionID => 0;

		public int Order => 0;

		public int Type => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_MessageEmoji Copy()
		{
			return null;
		}
	}
}
