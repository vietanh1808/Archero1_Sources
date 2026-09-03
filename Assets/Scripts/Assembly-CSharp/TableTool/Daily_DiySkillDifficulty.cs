using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DiySkillDifficulty : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Faceimg;

		private ObscuredInt _Star;

		private ObscuredInt _Addition;

		private ObscuredInt _AdditionItem;

		private ObscuredString[] _Reward;

		private ObscuredString _Boximg;

		private ObscuredFloat _EliteRate;

		private ObscuredInt[] _AddHPPerWave;

		private ObscuredInt _DropRate;

		public int ID => 0;

		public string Faceimg => null;

		public int Star => 0;

		public int Addition => 0;

		public int AdditionItem => 0;

		public string[] Reward => null;

		public string Boximg => null;

		public float EliteRate => 0f;

		public int[] AddHPPerWave => null;

		public int DropRate => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DiySkillDifficulty Copy()
		{
			return null;
		}
	}
}
