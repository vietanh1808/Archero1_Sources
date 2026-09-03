using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Wings_UpStar : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Progress;

		private ObscuredInt _Star;

		private ObscuredInt _Fragment_1;

		private ObscuredInt _Fragment_2;

		private ObscuredInt _Fragment_3;

		public int Id => 0;

		public int Progress => 0;

		public int Star => 0;

		public int Fragment_1 => 0;

		public int Fragment_2 => 0;

		public int Fragment_3 => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Wings_UpStar Copy()
		{
			return null;
		}
	}
}
