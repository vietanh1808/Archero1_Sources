using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Gambling_StonePool : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Pool;

		public int ID => 0;

		public string[] Pool => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Gambling_StonePool Copy()
		{
			return null;
		}
	}
}
