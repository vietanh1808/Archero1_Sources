using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Language_rename : LocalBean
	{
		private ObscuredString _TID;

		private ObscuredString _CN_s;

		public string TID => null;

		public string CN_s => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Language_rename Copy()
		{
			return null;
		}
	}
}
