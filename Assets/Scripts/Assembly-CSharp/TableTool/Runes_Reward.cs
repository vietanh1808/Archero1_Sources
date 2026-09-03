using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Runes_Reward : LocalBean
	{
		private ObscuredInt _CharID;

		private ObscuredInt _Rune;

		private ObscuredInt _NeedCount;

		private ObscuredString _Attributes;

		public int CharID => 0;

		public int Rune => 0;

		public int NeedCount => 0;

		public string Attributes => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Runes_Reward Copy()
		{
			return null;
		}
	}
}
