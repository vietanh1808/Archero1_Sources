using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_StarPlan : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _StarLevel;

		private ObscuredString[] _Star;

		private ObscuredInt[] _Buildability;

		private ObscuredString[] _Ability;

		private ObscuredInt _Exp;

		private ObscuredString[] _AbilityPreview;

		public int Id => 0;

		public int StarLevel => 0;

		public string[] Star => null;

		public int[] Buildability => null;

		public string[] Ability => null;

		public int Exp => 0;

		public string[] AbilityPreview => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_StarPlan Copy()
		{
			return null;
		}
	}
}
