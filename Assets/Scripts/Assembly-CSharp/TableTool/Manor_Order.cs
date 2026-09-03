using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_Order : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Type;

		private ObscuredString[] _Need;

		private ObscuredString[] _Reward;

		private ObscuredInt _Times;

		private ObscuredInt _Weight;

		private ObscuredInt _Version;

		private ObscuredInt _Value;

		public int Id => 0;

		public int Type => 0;

		public string[] Need => null;

		public string[] Reward => null;

		public int Times => 0;

		public int Weight => 0;

		public int Version => 0;

		public int Value => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_Order Copy()
		{
			return null;
		}
	}
}
