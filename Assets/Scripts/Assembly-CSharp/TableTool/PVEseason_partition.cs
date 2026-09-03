using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVEseason_partition : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _Standard;

		private ObscuredInt _StartId;

		private ObscuredInt _MaxStep1;

		private ObscuredInt _MaxStep2;

		private ObscuredInt _MaxStep3;

		private ObscuredInt _MaxGroupNum;

		private ObscuredInt _ConvertLimit;

		public int ID => 0;

		public int[] Standard => null;

		public int StartId => 0;

		public int MaxStep1 => 0;

		public int MaxStep2 => 0;

		public int MaxStep3 => 0;

		public int MaxGroupNum => 0;

		public int ConvertLimit => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVEseason_partition Copy()
		{
			return null;
		}
	}
}
