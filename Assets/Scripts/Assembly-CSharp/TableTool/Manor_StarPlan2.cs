using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_StarPlan2 : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString[] _Star;

		private ObscuredString[] _Ability;

		public int Id => 0;

		public string[] Star => null;

		public string[] Ability => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_StarPlan2 Copy()
		{
			return null;
		}
	}
}
