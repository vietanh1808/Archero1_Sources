using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Badge_Task : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _CondTypeArgs;

		private ObscuredString[] _Rewards;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _ShowVersion;

		public int ID => 0;

		public int Type => 0;

		public int CondTypeArgs => 0;

		public string[] Rewards => null;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public int ShowVersion => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Badge_Task Copy()
		{
			return null;
		}
	}
}
