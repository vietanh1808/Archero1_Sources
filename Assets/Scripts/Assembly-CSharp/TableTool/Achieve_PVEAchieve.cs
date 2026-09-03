using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Achieve_PVEAchieve : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _GlobalType;

		private ObscuredInt _CondTypeArgs;

		private ObscuredString[] _Rewards;

		private ObscuredInt _Mode;

		public int ID => 0;

		public int Type => 0;

		public int GlobalType => 0;

		public int CondTypeArgs => 0;

		public string[] Rewards => null;

		public int Mode => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Achieve_PVEAchieve Copy()
		{
			return null;
		}
	}
}
