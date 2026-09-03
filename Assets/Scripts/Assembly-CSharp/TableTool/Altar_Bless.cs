using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Altar_Bless : LocalBean
	{
		private ObscuredInt _BlessID;

		private ObscuredInt _LayerMin;

		private ObscuredInt _LayerMax;

		private ObscuredInt _BlessLevel;

		private ObscuredInt[] _EffectId;

		private ObscuredInt[] _EffectWeight;

		private ObscuredInt _RewardDropId;

		public int BlessID => 0;

		public int LayerMin => 0;

		public int LayerMax => 0;

		public int BlessLevel => 0;

		public int[] EffectId => null;

		public int[] EffectWeight => null;

		public int RewardDropId => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Altar_Bless Copy()
		{
			return null;
		}
	}
}
