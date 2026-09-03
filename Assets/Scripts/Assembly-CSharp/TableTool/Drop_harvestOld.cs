using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Drop_harvestOld : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _GoldDrop;

		private ObscuredInt _EquipExp;

		private ObscuredInt _StoneExp;

		private ObscuredInt _RefineExp;

		private ObscuredInt _Exp;

		private ObscuredInt _DropId;

		private ObscuredInt _BloodStoneExp;

		private ObscuredInt _SPDrop1Id;

		private ObscuredInt _SPDrop1Rate;

		private ObscuredInt _SPDrop1Limit;

		private ObscuredInt _SPDrop2Id;

		private ObscuredInt _SPDrop2Rate;

		private ObscuredInt _SPDrop2Limit;

		private ObscuredInt _CookieExp;

		public int ID => 0;

		public int GoldDrop => 0;

		public int EquipExp => 0;

		public int StoneExp => 0;

		public int RefineExp => 0;

		public int Exp => 0;

		public int DropId => 0;

		public int BloodStoneExp => 0;

		public int SPDrop1Id => 0;

		public int SPDrop1Rate => 0;

		public int SPDrop1Limit => 0;

		public int SPDrop2Id => 0;

		public int SPDrop2Rate => 0;

		public int SPDrop2Limit => 0;

		public int CookieExp => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Drop_harvestOld Copy()
		{
			return null;
		}
	}
}
