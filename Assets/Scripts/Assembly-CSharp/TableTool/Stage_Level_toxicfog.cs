using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Stage_Level_toxicfog : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Parameter;

		private ObscuredInt _BuffID;

		public int ID => 0;

		public string[] Parameter => null;

		public int BuffID => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Stage_Level_toxicfog Copy()
		{
			return null;
		}
	}
}
