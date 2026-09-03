using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_PvPConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _CostType;

		private ObscuredInt _CostNum;

		private ObscuredString[] _RewardWin;

		private ObscuredString[] _RewardLose;

		private ObscuredString[] _MapStyle;

		private ObscuredString[] _MapId;

		public int ID => 0;

		public int CostType => 0;

		public int CostNum => 0;

		public string[] RewardWin => null;

		public string[] RewardLose => null;

		public string[] MapStyle => null;

		public string[] MapId => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_PvPConfig Copy()
		{
			return null;
		}
	}
}
