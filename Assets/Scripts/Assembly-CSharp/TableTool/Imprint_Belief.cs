using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Imprint_Belief : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Level;

		private ObscuredInt _Exp;

		private ObscuredInt _Talent;

		public int ID => 0;

		public int Level => 0;

		public int Exp => 0;

		public int Talent => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Imprint_Belief Copy()
		{
			return null;
		}
	}
}
