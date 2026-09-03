using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Exp_exp : LocalBean
	{
		private ObscuredInt _LevelID;

		private ObscuredString _Notes;

		private ObscuredInt _Exp;

		public int LevelID => 0;

		public string Notes => null;

		public int Exp => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Exp_exp Copy()
		{
			return null;
		}
	}
}
