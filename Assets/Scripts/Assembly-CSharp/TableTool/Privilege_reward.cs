using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Privilege_reward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _DropID;

		private ObscuredString[] _Show;

		public int ID => 0;

		public int DropID => 0;

		public string[] Show => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Privilege_reward Copy()
		{
			return null;
		}
	}
}
