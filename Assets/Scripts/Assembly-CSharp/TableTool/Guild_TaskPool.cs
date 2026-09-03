using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_TaskPool : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Language;

		private ObscuredInt _Type;

		private ObscuredInt _Go;

		private ObscuredInt[] _AgrsType;

		private ObscuredInt _FakeType;

		private ObscuredInt[] _Args;

		private ObscuredInt _Count;

		private ObscuredString _Icon;

		private ObscuredInt _NeedLayer;

		private ObscuredInt _NeedLevel;

		private ObscuredInt _Weight;

		private ObscuredInt _Exp;

		private ObscuredInt _Score;

		private ObscuredInt _Quality;

		public int ID => 0;

		public string Language => null;

		public int Type => 0;

		public int Go => 0;

		public int[] AgrsType => null;

		public int FakeType => 0;

		public int[] Args => null;

		public int Count => 0;

		public string Icon => null;

		public int NeedLayer => 0;

		public int NeedLevel => 0;

		public int Weight => 0;

		public int Exp => 0;

		public int Score => 0;

		public int Quality => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_TaskPool Copy()
		{
			return null;
		}
	}
}
