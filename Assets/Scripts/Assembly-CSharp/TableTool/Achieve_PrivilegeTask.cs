using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Achieve_PrivilegeTask : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredString _Language;

		private ObscuredInt _TypeValue;

		private ObscuredString[] _Reward;

		private ObscuredInt[] _Activity_ability;

		public int ID => 0;

		public int Type => 0;

		public string Language => null;

		public int TypeValue => 0;

		public string[] Reward => null;

		public int[] Activity_ability => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Achieve_PrivilegeTask Copy()
		{
			return null;
		}
	}
}
