using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_Event : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt[] _MinNum;

		private ObscuredInt[] _MaxNum;

		private ObscuredInt _MaxNumMax;

		private ObscuredInt _CostGems;

		private ObscuredString[] _GetType;

		private ObscuredInt[] _GetDropId;

		private ObscuredInt[] _Countdown;

		private ObscuredInt _StealProbability;

		private ObscuredString[] _StealType;

		private ObscuredInt[] _StealDropId;

		private ObscuredInt[] _StealMaxNum;

		private ObscuredInt _StealMax;

		public int ID => 0;

		public int Type => 0;

		public int[] MinNum => null;

		public int[] MaxNum => null;

		public int MaxNumMax => 0;

		public int CostGems => 0;

		public new string[] GetType => null;

		public int[] GetDropId => null;

		public int[] Countdown => null;

		public int StealProbability => 0;

		public string[] StealType => null;

		public int[] StealDropId => null;

		public int[] StealMaxNum => null;

		public int StealMax => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_Event Copy()
		{
			return null;
		}
	}
}
