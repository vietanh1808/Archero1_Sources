using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVEStage_StageRatio : LocalBean
	{
		private ObscuredInt _StageID;

		private ObscuredFloat _BaseCampHPRatio;

		private ObscuredFloat _TDAttackRatio;

		public int StageID => 0;

		public float BaseCampHPRatio => 0f;

		public float TDAttackRatio => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVEStage_StageRatio Copy()
		{
			return null;
		}
	}
}
