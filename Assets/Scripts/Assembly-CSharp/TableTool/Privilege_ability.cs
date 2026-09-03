using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Privilege_ability : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt[] _Parameter;

		private ObscuredString _Img;

		private ObscuredInt _Ver;

		public int ID => 0;

		public int Type => 0;

		public int[] Parameter => null;

		public string Img => null;

		public int Ver => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Privilege_ability Copy()
		{
			return null;
		}
	}
}
