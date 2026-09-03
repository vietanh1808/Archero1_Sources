using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Relics_ExtraAttributes : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _RelicsCondition;

		private ObscuredString _Args;

		private ObscuredString _ArgsExtra;

		private ObscuredString _Target;

		public int ID => 0;

		public int RelicsCondition => 0;

		public string Args => null;

		public string ArgsExtra => null;

		public string Target => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Relics_ExtraAttributes Copy()
		{
			return null;
		}
	}
}
