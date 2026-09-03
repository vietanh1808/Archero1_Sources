using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DefenseDifficulty_129 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredFloat _PointMultiplier;

		private ObscuredInt _BattleSpeed;

		private ObscuredFloat _BattleTrueSpeed;

		private ObscuredInt _Health;

		private ObscuredInt _CoinNum;

		private ObscuredInt _PointMax;

		private ObscuredString _Colorimg;

		public int ID => 0;

		public float PointMultiplier => 0f;

		public int BattleSpeed => 0;

		public float BattleTrueSpeed => 0f;

		public int Health => 0;

		public int CoinNum => 0;

		public int PointMax => 0;

		public string Colorimg => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DefenseDifficulty_129 Copy()
		{
			return null;
		}
	}
}
