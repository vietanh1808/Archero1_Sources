using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLGStage_Level202 : LocalBean
	{
		private ObscuredInt _RoundID;

		private ObscuredString[] _Attributes;

		private ObscuredString[] _MapAttributes;

		private ObscuredLong _StandardDefence;

		private ObscuredInt _MonsterNest;

		private ObscuredInt _EliteArg;

		private ObscuredInt _MonsterNumUp;

		public int RoundID => 0;

		public string[] Attributes => null;

		public string[] MapAttributes => null;

		public long StandardDefence => 0L;

		public int MonsterNest => 0;

		public int EliteArg => 0;

		public int MonsterNumUp => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLGStage_Level202 Copy()
		{
			return null;
		}
	}
}
