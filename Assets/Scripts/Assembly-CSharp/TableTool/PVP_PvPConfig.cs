using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVP_PvPConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _CostType;

		private ObscuredInt _CostNum;

		private ObscuredString[] _RewardWin;

		private ObscuredString[] _RewardWLose;

		private ObscuredString[] _MapStyle;

		private ObscuredString[] _MapId;

		public int ID => 0;

		public int CostType => 0;

		public int CostNum => 0;

		public string[] RewardWin => null;

		public string[] RewardWLose => null;

		public string[] MapStyle => null;

		public string[] MapId => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVP_PvPConfig Copy()
		{
			return null;
		}
	}
}
