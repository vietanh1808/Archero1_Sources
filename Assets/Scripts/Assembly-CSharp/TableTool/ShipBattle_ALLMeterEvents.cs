using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_ALLMeterEvents : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Meter;

		private ObscuredInt _RankID;

		private ObscuredInt _OpenTime;

		private ObscuredInt _CloseTime;

		private ObscuredInt _EndShowTime;

		private ObscuredString _Events;

		private ObscuredInt _Limit;

		private ObscuredInt _TreasureStartTime;

		private ObscuredInt _TreasureEndTime;

		private ObscuredInt[] _Special3Debuff;

		public int ID => 0;

		public int Meter => 0;

		public int RankID => 0;

		public int OpenTime => 0;

		public int CloseTime => 0;

		public int EndShowTime => 0;

		public string Events => null;

		public int Limit => 0;

		public int TreasureStartTime => 0;

		public int TreasureEndTime => 0;

		public int[] Special3Debuff => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_ALLMeterEvents Copy()
		{
			return null;
		}
	}
}
