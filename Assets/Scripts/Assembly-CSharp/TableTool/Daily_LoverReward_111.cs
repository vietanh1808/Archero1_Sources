using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_LoverReward_111 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredString _Notes;

		private ObscuredInt _Type;

		private ObscuredString[] _Rewards;

		private ObscuredString[] _NeedPoints;

		public int ID => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public string Notes => null;

		public int Type => 0;

		public string[] Rewards => null;

		public string[] NeedPoints => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_LoverReward_111 Copy()
		{
			return null;
		}
	}
}
