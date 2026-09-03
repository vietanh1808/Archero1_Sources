using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipStage_ShipDifficultyWeight : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Difficulty;

		private ObscuredInt _Type;

		private ObscuredInt _Pos;

		private ObscuredInt _Weight;

		public int ID => 0;

		public int Difficulty => 0;

		public int Type => 0;

		public int Pos => 0;

		public int Weight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipStage_ShipDifficultyWeight Copy()
		{
			return null;
		}
	}
}
