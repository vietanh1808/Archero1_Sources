using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrialFree_128 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _FreeArtifact;

		public int ID => 0;

		public int[] FreeArtifact => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrialFree_128 Copy()
		{
			return null;
		}
	}
}
