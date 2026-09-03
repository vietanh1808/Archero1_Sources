using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Privilege_activity_ability : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _Parameter;

		private ObscuredString _Img;

		private ObscuredInt _Ver;

		private ObscuredString _ShowNum;

		public int ID => 0;

		public int Type => 0;

		public int Parameter => 0;

		public string Img => null;

		public int Ver => 0;

		public string ShowNum => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Privilege_activity_ability Copy()
		{
			return null;
		}
	}
}
