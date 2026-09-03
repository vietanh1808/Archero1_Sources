using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_MosterBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Name;

		private ObscuredInt _Quality;

		private ObscuredString _GiftIcon;

		private ObscuredString _Cost;

		private ObscuredInt _Num;

		private ObscuredString[] _Reward;

		public int ID => 0;

		public string Name => null;

		public int Quality => 0;

		public string GiftIcon => null;

		public string Cost => null;

		public int Num => 0;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_MosterBox Copy()
		{
			return null;
		}
	}
}
