using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_MultipleEvents : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _Stage;

		private ObscuredInt _PreTime;

		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _ShowTime;

		public int ID => 0;

		public int Type => 0;

		public int Stage => 0;

		public int PreTime => 0;

		public int StartTime => 0;

		public int EndTime => 0;

		public int ShowTime => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_MultipleEvents Copy()
		{
			return null;
		}
	}
}
