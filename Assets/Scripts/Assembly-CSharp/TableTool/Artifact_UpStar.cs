using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Artifact_UpStar : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Progress;

		private ObscuredInt _Star;

		private ObscuredString[] _Item_1;

		private ObscuredString[] _Item_2;

		private ObscuredString[] _Item_3;

		private ObscuredInt _Fragment_1;

		private ObscuredInt _Fragment_2;

		private ObscuredInt _Fragment_3;

		private ObscuredInt _ATK_Attributes;

		private ObscuredInt _HP_Attributes;

		public int Id => 0;

		public int Progress => 0;

		public int Star => 0;

		public string[] Item_1 => null;

		public string[] Item_2 => null;

		public string[] Item_3 => null;

		public int Fragment_1 => 0;

		public int Fragment_2 => 0;

		public int Fragment_3 => 0;

		public int ATK_Attributes => 0;

		public int HP_Attributes => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Artifact_UpStar Copy()
		{
			return null;
		}
	}
}
