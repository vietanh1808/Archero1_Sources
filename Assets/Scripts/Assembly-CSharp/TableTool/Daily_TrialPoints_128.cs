using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrialPoints_128 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Tag;

		private ObscuredInt[] _Points;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int Tag => 0;

		public int[] Points => null;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrialPoints_128 Copy()
		{
			return null;
		}
	}
}
