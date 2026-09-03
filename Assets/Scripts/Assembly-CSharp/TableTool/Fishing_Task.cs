using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Fishing_Task : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _Type;

		private ObscuredInt _Position;

		private ObscuredInt _UnlockId;

		private ObscuredInt _CondTypeArgs;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public int Type => 0;

		public int Position => 0;

		public int UnlockId => 0;

		public int CondTypeArgs => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Fishing_Task Copy()
		{
			return null;
		}
	}
}
