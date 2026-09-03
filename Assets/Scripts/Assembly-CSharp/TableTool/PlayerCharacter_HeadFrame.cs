using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_HeadFrame : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Quality;

		private ObscuredInt _Type;

		private ObscuredInt _TypeArgs;

		private ObscuredString _Condition;

		private ObscuredString _IfDisplay;

		private ObscuredInt _Streamer;

		private ObscuredInt _Rank;

		private ObscuredInt _IfHide;

		private ObscuredInt[] _Limit;

		private ObscuredString[] _Attribute;

		private ObscuredInt _EffectId;

		private ObscuredInt _IfImg;

		public int Id => 0;

		public int Quality => 0;

		public int Type => 0;

		public int TypeArgs => 0;

		public string Condition => null;

		public string IfDisplay => null;

		public int Streamer => 0;

		public int Rank => 0;

		public int IfHide => 0;

		public int[] Limit => null;

		public string[] Attribute => null;

		public int EffectId => 0;

		public int IfImg => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_HeadFrame Copy()
		{
			return null;
		}
	}
}
