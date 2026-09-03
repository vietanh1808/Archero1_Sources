using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_HeroDefenceAffinity : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _Affinity;

		private ObscuredString _Awards;

		public int ID => 0;

		public int[] Affinity => null;

		public string Awards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_HeroDefenceAffinity Copy()
		{
			return null;
		}
	}
}
