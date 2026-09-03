using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Tower_EventTowerChest : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Tag;

		private ObscuredInt _Progress;

		private ObscuredInt _Gap;

		private ObscuredInt _Minlevel;

		private ObscuredInt _Maxlevel;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int Tag => 0;

		public int Progress => 0;

		public int Gap => 0;

		public int Minlevel => 0;

		public int Maxlevel => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Tower_EventTowerChest Copy()
		{
			return null;
		}
	}
}
