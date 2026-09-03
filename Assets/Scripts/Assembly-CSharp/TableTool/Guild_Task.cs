using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_Task : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _TaskConfig;

		private ObscuredInt _NeedLevel;

		public int ID => 0;

		public int[] TaskConfig => null;

		public int NeedLevel => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_Task Copy()
		{
			return null;
		}
	}
}
