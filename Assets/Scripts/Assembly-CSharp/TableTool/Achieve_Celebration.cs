using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Achieve_Celebration : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Language;

		private ObscuredInt _Type;

		private ObscuredInt _Go;

		private ObscuredInt[] _AgrsType;

		private ObscuredInt _FakeType;

		private ObscuredInt[] _Args;

		private ObscuredInt _Count;

		private ObscuredInt _NeedLayer;

		public int ID => 0;

		public string Language => null;

		public int Type => 0;

		public int Go => 0;

		public int[] AgrsType => null;

		public int FakeType => 0;

		public int[] Args => null;

		public int Count => 0;

		public int NeedLayer => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Achieve_Celebration Copy()
		{
			return null;
		}
	}
}
