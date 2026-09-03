using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Fishing_Catalog : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Num;

		private ObscuredString[] _Reward;

		public int ID => 0;

		public int Num => 0;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Fishing_Catalog Copy()
		{
			return null;
		}
	}
}
