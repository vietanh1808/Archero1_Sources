using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Drop_DropShow : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _ChestType;

		private ObscuredInt _EquipId;

		private ObscuredInt _Probability;

		private ObscuredInt _ItemType;

		public int ID => 0;

		public int ChestType => 0;

		public int EquipId => 0;

		public int Probability => 0;

		public int ItemType => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Drop_DropShow Copy()
		{
			return null;
		}
	}
}
