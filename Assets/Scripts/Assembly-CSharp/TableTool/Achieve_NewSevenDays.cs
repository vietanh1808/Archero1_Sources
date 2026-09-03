using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Achieve_NewSevenDays : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Note1;

		private ObscuredString _Note2;

		private ObscuredString _Language;

		private ObscuredInt _Type;

		private ObscuredInt _Go;

		private ObscuredInt[] _AgrsType;

		private ObscuredInt _FakeType;

		private ObscuredInt[] _Args;

		private ObscuredInt _Count;

		private ObscuredInt _NeedLayer;

		private ObscuredInt _MaxLayer;

		private ObscuredInt _Tag;

		private ObscuredInt _Day;

		private ObscuredInt _RewardPoint;

		private ObscuredString[] _Reward;

		public int ID => 0;

		public string Note1 => null;

		public string Note2 => null;

		public string Language => null;

		public int Type => 0;

		public int Go => 0;

		public int[] AgrsType => null;

		public int FakeType => 0;

		public int[] Args => null;

		public int Count => 0;

		public int NeedLayer => 0;

		public int MaxLayer => 0;

		public int Tag => 0;

		public int Day => 0;

		public int RewardPoint => 0;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Achieve_NewSevenDays Copy()
		{
			return null;
		}
	}
}
