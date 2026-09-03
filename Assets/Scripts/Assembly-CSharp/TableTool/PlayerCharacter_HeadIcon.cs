using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_HeadIcon : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Quality;

		private ObscuredString _Icon;

		private ObscuredString _Condition;

		private ObscuredString _IfDisplay;

		private ObscuredInt _Streamer;

		private ObscuredInt _IfHide;

		private ObscuredInt[] _Limit;

		private ObscuredString[] _Attribute;

		public int Id => 0;

		public int Quality => 0;

		public string Icon => null;

		public string Condition => null;

		public string IfDisplay => null;

		public int Streamer => 0;

		public int IfHide => 0;

		public int[] Limit => null;

		public string[] Attribute => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_HeadIcon Copy()
		{
			return null;
		}
	}
}
