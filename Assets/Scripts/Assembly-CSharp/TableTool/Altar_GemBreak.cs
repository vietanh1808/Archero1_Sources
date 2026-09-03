using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Altar_GemBreak : LocalBean
	{
		private ObscuredInt _BreakID;

		private ObscuredInt _LevelMax;

		private ObscuredInt _GemBar;

		private ObscuredInt _BloodRate;

		private ObscuredInt[] _GemLevelList;

		private ObscuredString _Attribute1;

		private ObscuredString _Attribute2;

		private ObscuredString _Attribute3;

		private ObscuredString _Attribute4;

		private ObscuredString _Attribute5;

		private ObscuredString _Attribute6;

		private ObscuredString _Attribute7;

		private ObscuredString _Attribute8;

		private ObscuredString _Attribute9;

		private ObscuredString _Attribute10;

		private ObscuredInt _ShowId;

		private ObscuredInt _BlessLevel;

		public int BreakID => 0;

		public int LevelMax => 0;

		public int GemBar => 0;

		public int BloodRate => 0;

		public int[] GemLevelList => null;

		public string Attribute1 => null;

		public string Attribute2 => null;

		public string Attribute3 => null;

		public string Attribute4 => null;

		public string Attribute5 => null;

		public string Attribute6 => null;

		public string Attribute7 => null;

		public string Attribute8 => null;

		public string Attribute9 => null;

		public string Attribute10 => null;

		public int ShowId => 0;

		public int BlessLevel => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Altar_GemBreak Copy()
		{
			return null;
		}
	}
}
