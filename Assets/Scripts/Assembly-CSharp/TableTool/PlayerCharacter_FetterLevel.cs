using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_FetterLevel : LocalBean
	{
		private ObscuredInt _StarLimit;

		private ObscuredInt _FetterLevelId;

		public int StarLimit => 0;

		public int FetterLevelId => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_FetterLevel Copy()
		{
			return null;
		}
	}
}
