using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_HeroPartyDifficult : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Item1;

		private ObscuredInt _Equip;

		private ObscuredInt _Gold;

		private ObscuredInt _JewelSet;

		private ObscuredInt _BloodStone;

		private ObscuredString[] _Attributes;

		private ObscuredInt _EliteRate;

		public int ID => 0;

		public int Item1 => 0;

		public int Equip => 0;

		public int Gold => 0;

		public int JewelSet => 0;

		public int BloodStone => 0;

		public string[] Attributes => null;

		public int EliteRate => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_HeroPartyDifficult Copy()
		{
			return null;
		}
	}
}
