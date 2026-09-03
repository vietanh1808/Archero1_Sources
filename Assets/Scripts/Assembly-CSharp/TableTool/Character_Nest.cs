using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Character_Nest : LocalBean
	{
		private ObscuredInt _NestID;

		private ObscuredString[] _Monster;

		public int NestID => 0;

		public string[] Monster => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Character_Nest Copy()
		{
			return null;
		}
	}
}
