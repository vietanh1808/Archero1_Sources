using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_Material : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _BuildID;

		private ObscuredInt _Time;

		public int Id => 0;

		public int BuildID => 0;

		public int Time => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_Material Copy()
		{
			return null;
		}
	}
}
