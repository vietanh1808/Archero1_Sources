using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_BattlePassPower : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _BPType;

		private ObscuredInt _PowerType;

		private ObscuredInt _Value;

		private ObscuredInt _ValueType;

		public int Id => 0;

		public int BPType => 0;

		public int PowerType => 0;

		public int Value => 0;

		public int ValueType => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_BattlePassPower Copy()
		{
			return null;
		}
	}
}
