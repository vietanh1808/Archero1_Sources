using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_BagReward_125 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Faceimg;

		private ObscuredInt _Star;

		private ObscuredInt _Addition;

		private ObscuredString[] _Reward;

		private ObscuredString _Boximg;

		private ObscuredFloat _EliteRate;

		private ObscuredFloat[] _AddMonsterPerWave;

		public int ID => 0;

		public string Faceimg => null;

		public int Star => 0;

		public int Addition => 0;

		public string[] Reward => null;

		public string Boximg => null;

		public float EliteRate => 0f;

		public float[] AddMonsterPerWave => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_BagReward_125 Copy()
		{
			return null;
		}
	}
}
