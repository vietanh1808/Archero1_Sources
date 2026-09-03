using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Achieve_PVEtalentAchieve : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _CondTypeArgs;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int Type => 0;

		public int CondTypeArgs => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Achieve_PVEtalentAchieve Copy()
		{
			return null;
		}
	}
}
