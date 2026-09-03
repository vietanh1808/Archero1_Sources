using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Character_Call : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _CallID;

		private ObscuredString[] _EliteCallID;

		public int ID => 0;

		public string[] CallID => null;

		public string[] EliteCallID => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Character_Call Copy()
		{
			return null;
		}
	}
}
