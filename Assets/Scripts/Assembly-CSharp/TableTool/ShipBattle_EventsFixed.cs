using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_EventsFixed : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MinDay;

		private ObscuredInt _MaxDay;

		private ObscuredInt _EventId;

		private ObscuredInt _Strength;

		private ObscuredInt _EventNum;

		public int ID => 0;

		public int MinDay => 0;

		public int MaxDay => 0;

		public int EventId => 0;

		public int Strength => 0;

		public int EventNum => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_EventsFixed Copy()
		{
			return null;
		}
	}
}
