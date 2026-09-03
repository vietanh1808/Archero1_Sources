using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Character_Level : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Exp;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int Exp => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Character_Level Copy()
		{
			return null;
		}
	}
}
