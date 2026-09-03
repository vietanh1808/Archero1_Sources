using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Stage_Level_hellstagebuff : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Img;

		private ObscuredInt _Type;

		private ObscuredInt _Target;

		private ObscuredInt[] _AllType;

		private ObscuredString _Effect;

		private ObscuredString _Attributes;

		private ObscuredString _AttributesNum;

		private ObscuredInt _EnvironmentStar;

		public int ID => 0;

		public string Img => null;

		public int Type => 0;

		public int Target => 0;

		public int[] AllType => null;

		public string Effect => null;

		public string Attributes => null;

		public string AttributesNum => null;

		public int EnvironmentStar => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Stage_Level_hellstagebuff Copy()
		{
			return null;
		}
	}
}
