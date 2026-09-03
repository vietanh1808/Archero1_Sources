using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_RedEnvelope : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _Quality;

		private ObscuredString _Name;

		private ObscuredString _Text;

		private ObscuredString _ProductText;

		private ObscuredString _Icon;

		private ObscuredInt _Bg_type;

		private ObscuredString _Reward;

		private ObscuredString _RewardNew;

		private ObscuredInt _VersionNew;

		private ObscuredInt _Condition;

		private ObscuredString[] _RewardDisplay;

		private ObscuredString _Reward_Title;

		private ObscuredInt _Exp;

		public int ID => 0;

		public int Type => 0;

		public int Quality => 0;

		public string Name => null;

		public string Text => null;

		public string ProductText => null;

		public string Icon => null;

		public int Bg_type => 0;

		public string Reward => null;

		public string RewardNew => null;

		public int VersionNew => 0;

		public int Condition => 0;

		public string[] RewardDisplay => null;

		public string Reward_Title => null;

		public int Exp => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_RedEnvelope Copy()
		{
			return null;
		}
	}
}
