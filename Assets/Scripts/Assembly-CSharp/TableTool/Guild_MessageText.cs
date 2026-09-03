using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_MessageText : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _LanguageID;

		private ObscuredInt _Order;

		public int ID => 0;

		public string LanguageID => null;

		public int Order => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_MessageText Copy()
		{
			return null;
		}
	}
}
