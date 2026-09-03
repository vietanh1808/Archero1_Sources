using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_Mine3 : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Shell;

		private ObscuredInt[] _Drawing;

		private ObscuredInt _FountainLV;

		private ObscuredString _Capacity;

		private ObscuredString[] _Ability;

		public int Id => 0;

		public int Shell => 0;

		public int[] Drawing => null;

		public int FountainLV => 0;

		public string Capacity => null;

		public string[] Ability => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_Mine3 Copy()
		{
			return null;
		}
	}
}
