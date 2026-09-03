using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Totem_TotemUpgrade : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString[] _Upgrade2;

		private ObscuredString[] _Upgrade3;

		private ObscuredString[] _Upgrade4;

		private ObscuredString[] _Upgrade6;

		private ObscuredString[] _Resolve2;

		private ObscuredString[] _Resolve3;

		private ObscuredString[] _Resolve4;

		private ObscuredString[] _Resolve6;

		public int Id => 0;

		public string[] Upgrade2 => null;

		public string[] Upgrade3 => null;

		public string[] Upgrade4 => null;

		public string[] Upgrade6 => null;

		public string[] Resolve2 => null;

		public string[] Resolve3 => null;

		public string[] Resolve4 => null;

		public string[] Resolve6 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Totem_TotemUpgrade Copy()
		{
			return null;
		}
	}
}
