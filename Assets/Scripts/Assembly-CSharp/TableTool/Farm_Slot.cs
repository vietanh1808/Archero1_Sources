using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_Slot : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Items;

		private ObscuredInt[] _ThreeProbability;

		private ObscuredInt[] _TwoProbability;

		private ObscuredInt[] _OneProbability;

		private ObscuredInt[] _ThreeItemRatio;

		private ObscuredInt[] _TwoItemRatio;

		private ObscuredInt[] _TwoItemRatioNew;

		private ObscuredInt _MinLayer;

		private ObscuredInt _MaxLayer;

		private ObscuredInt _Weights;

		private ObscuredInt _DropId;

		private ObscuredInt _Version;

		public int ID => 0;

		public string[] Items => null;

		public int[] ThreeProbability => null;

		public int[] TwoProbability => null;

		public int[] OneProbability => null;

		public int[] ThreeItemRatio => null;

		public int[] TwoItemRatio => null;

		public int[] TwoItemRatioNew => null;

		public int MinLayer => 0;

		public int MaxLayer => 0;

		public int Weights => 0;

		public int DropId => 0;

		public int Version => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_Slot Copy()
		{
			return null;
		}
	}
}
