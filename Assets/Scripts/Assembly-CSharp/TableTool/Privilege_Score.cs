using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Privilege_Score : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Product;

		private ObscuredInt _Score;

		public int ID => 0;

		public string Product => null;

		public int Score => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Privilege_Score Copy()
		{
			return null;
		}
	}
}
