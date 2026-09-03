using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_Worker : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Number;

		private ObscuredInt _Quality;

		private ObscuredInt _Type;

		private ObscuredInt _Fragment;

		private ObscuredInt _Convert;

		private ObscuredInt _Complete;

		private ObscuredInt[] _StarNum;

		private ObscuredInt[] _StarCoinNum;

		private ObscuredString[] _Attributes;

		private ObscuredInt[] _Buildability;

		private ObscuredString[] _Ability;

		public int Id => 0;

		public string Number => null;

		public int Quality => 0;

		public int Type => 0;

		public int Fragment => 0;

		public int Convert => 0;

		public int Complete => 0;

		public int[] StarNum => null;

		public int[] StarCoinNum => null;

		public string[] Attributes => null;

		public int[] Buildability => null;

		public string[] Ability => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_Worker Copy()
		{
			return null;
		}
	}
}
