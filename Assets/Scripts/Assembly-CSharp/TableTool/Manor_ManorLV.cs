using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_ManorLV : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Exp;

		private ObscuredString[] _Reward;

		public int Id => 0;

		public int Exp => 0;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_ManorLV Copy()
		{
			return null;
		}
	}
}
