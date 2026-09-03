using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_WheelBase : LocalBean
	{
		private ObscuredInt _StartTime;

		private ObscuredInt _EndTime;

		private ObscuredInt _OpenGameLevel;

		private ObscuredInt _FreeCount1;

		private ObscuredInt[] _Price1;

		private ObscuredInt[] _FreeItem1;

		private ObscuredInt[] _InterWheel1;

		private ObscuredInt[] _GrandPrize1;

		private ObscuredInt _WheelCount1;

		private ObscuredInt _FreeCount2;

		private ObscuredInt[] _Price2;

		private ObscuredInt[] _FreeItem2;

		private ObscuredInt[] _InterWheel2;

		private ObscuredInt[] _GrandPrize2;

		private ObscuredInt _WheelCount2;

		public int StartTime => 0;

		public int EndTime => 0;

		public int OpenGameLevel => 0;

		public int FreeCount1 => 0;

		public int[] Price1 => null;

		public int[] FreeItem1 => null;

		public int[] InterWheel1 => null;

		public int[] GrandPrize1 => null;

		public int WheelCount1 => 0;

		public int FreeCount2 => 0;

		public int[] Price2 => null;

		public int[] FreeItem2 => null;

		public int[] InterWheel2 => null;

		public int[] GrandPrize2 => null;

		public int WheelCount2 => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_WheelBase Copy()
		{
			return null;
		}
	}
}
