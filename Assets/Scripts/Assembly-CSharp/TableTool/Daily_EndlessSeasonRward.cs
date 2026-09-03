using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_EndlessSeasonRward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Level;

		private ObscuredInt _Season;

		private ObscuredString[] _Reaward;

		public int ID => 0;

		public int Level => 0;

		public int Season => 0;

		public string[] Reaward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_EndlessSeasonRward Copy()
		{
			return null;
		}
	}
}
