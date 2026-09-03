using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_TreasureBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _BuildingID;

		private ObscuredInt _Partition;

		private ObscuredInt _OpenType;

		private ObscuredString[] _CostItem;

		private ObscuredString[] _Fixed_Reward;

		private ObscuredString[] _Random_Reward1;

		public int ID => 0;

		public int BuildingID => 0;

		public int Partition => 0;

		public int OpenType => 0;

		public string[] CostItem => null;

		public string[] Fixed_Reward => null;

		public string[] Random_Reward1 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_TreasureBox Copy()
		{
			return null;
		}
	}
}
