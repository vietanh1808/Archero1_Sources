using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrialMonsterMessage_128 : LocalBean
	{
		private ObscuredInt _MonsterID;

		private ObscuredString _Name;

		private ObscuredInt _Speed;

		private ObscuredInt _Attack;

		private ObscuredInt _HP;

		private ObscuredInt _Collision;

		public int MonsterID => 0;

		public string Name => null;

		public int Speed => 0;

		public int Attack => 0;

		public int HP => 0;

		public int Collision => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrialMonsterMessage_128 Copy()
		{
			return null;
		}
	}
}
