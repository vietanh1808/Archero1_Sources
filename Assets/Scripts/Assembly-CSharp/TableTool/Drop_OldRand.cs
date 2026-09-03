using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Drop_OldRand : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _NeedLevel;

		private ObscuredInt[] _Rand;

		private ObscuredInt _FackDropId;

		public int ID => 0;

		public int[] NeedLevel => null;

		public int[] Rand => null;

		public int FackDropId => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Drop_OldRand Copy()
		{
			return null;
		}
	}
}
