using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Drop_Gold : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _GoldDropLevel;

		public int ID => 0;

		public string[] GoldDropLevel => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Drop_Gold Copy()
		{
			return null;
		}
	}
}
