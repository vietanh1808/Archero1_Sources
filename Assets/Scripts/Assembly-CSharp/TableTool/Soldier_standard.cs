using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Soldier_standard : LocalBean
	{
		private ObscuredInt _Level;

		private ObscuredInt _Integral_Up;

		private ObscuredInt _Integral_Down;

		private ObscuredInt _Standard_Attack;

		private ObscuredInt _Standard_HpMax;

		private ObscuredFloat _Coins_Ratio;

		private ObscuredFloat _Exp_Ratio;

		private ObscuredString[] _ScrollRate;

		private ObscuredString[] _ScrollRateBoss;

		public int Level => 0;

		public int Integral_Up => 0;

		public int Integral_Down => 0;

		public int Standard_Attack => 0;

		public int Standard_HpMax => 0;

		public float Coins_Ratio => 0f;

		public float Exp_Ratio => 0f;

		public string[] ScrollRate => null;

		public string[] ScrollRateBoss => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Soldier_standard Copy()
		{
			return null;
		}
	}
}
