using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_TalentAchieve : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _GlobalType;

		private ObscuredInt _CondTypeArgs;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int Type => 0;

		public int GlobalType => 0;

		public int CondTypeArgs => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_TalentAchieve Copy()
		{
			return null;
		}
	}
}
