using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Altar_EquipUpgrade : LocalBean
	{
		private ObscuredInt _LevelID;

		private ObscuredInt _BloodNum;

		private ObscuredInt _ScrollId;

		private ObscuredInt _ScrollNum;

		private ObscuredString _Attribute1;

		private ObscuredString _Attribute2;

		private ObscuredString _Attribute3;

		private ObscuredString _Attribute4;

		private ObscuredString _Attribute5;

		public int LevelID => 0;

		public int BloodNum => 0;

		public int ScrollId => 0;

		public int ScrollNum => 0;

		public string Attribute1 => null;

		public string Attribute2 => null;

		public string Attribute3 => null;

		public string Attribute4 => null;

		public string Attribute5 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Altar_EquipUpgrade Copy()
		{
			return null;
		}
	}
}
