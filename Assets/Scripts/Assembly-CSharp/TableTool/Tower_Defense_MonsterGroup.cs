using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Tower_Defense_MonsterGroup : LocalBean
	{
		private ObscuredInt _GroupID;

		private ObscuredString[] _MonsterID;

		private ObscuredInt _MIntervals;

		private ObscuredInt _GIntervals;

		public int GroupID => 0;

		public string[] MonsterID => null;

		public int MIntervals => 0;

		public int GIntervals => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Tower_Defense_MonsterGroup Copy()
		{
			return null;
		}
	}
}
