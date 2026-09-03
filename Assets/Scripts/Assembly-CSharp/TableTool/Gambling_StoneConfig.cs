using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Gambling_StoneConfig : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Icon;

		private ObscuredString _Nmae;

		private ObscuredInt _Price;

		private ObscuredString[] _Item;

		private ObscuredString[] _ItemSuper;

		public int ID => 0;

		public string Icon => null;

		public string Nmae => null;

		public int Price => 0;

		public string[] Item => null;

		public string[] ItemSuper => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Gambling_StoneConfig Copy()
		{
			return null;
		}
	}
}
