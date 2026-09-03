using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Artifact_Position : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _LevelLimit;

		public int Id => 0;

		public int LevelLimit => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Artifact_Position Copy()
		{
			return null;
		}
	}
}
