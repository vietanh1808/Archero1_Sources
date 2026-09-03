using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_BattleSeason : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Notes;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt[] _MonsterUPCycle;

		private ObscuredInt _MonsterBoxCycle;

		private ObscuredInt _MapStyle;

		public int Id => 0;

		public string Notes => null;

		public int StartTime => 0;

		public int EndTime => 0;

		public int[] MonsterUPCycle => null;

		public int MonsterBoxCycle => 0;

		public int MapStyle => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_BattleSeason Copy()
		{
			return null;
		}
	}
}
