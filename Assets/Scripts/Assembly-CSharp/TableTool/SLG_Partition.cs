using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_Partition : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _StartId;

		private ObscuredInt _GroupNum;

		private ObscuredInt _MaxStep1;

		private ObscuredInt _MaxStep2;

		public int ID => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public int StartId => 0;

		public int GroupNum => 0;

		public int MaxStep1 => 0;

		public int MaxStep2 => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_Partition Copy()
		{
			return null;
		}
	}
}
