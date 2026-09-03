using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_Desert11 : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Wood;

		private ObscuredInt _Stone;

		private ObscuredInt _Leather;

		private ObscuredInt _Amethyst_;

		private ObscuredInt[] _Drawing;

		private ObscuredInt _FountainLV;

		private ObscuredString _Capacity;

		private ObscuredString[] _Ability;

		public int Id => 0;

		public int Wood => 0;

		public int Stone => 0;

		public int Leather => 0;

		public int Amethyst_ => 0;

		public int[] Drawing => null;

		public int FountainLV => 0;

		public string Capacity => null;

		public string[] Ability => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_Desert11 Copy()
		{
			return null;
		}
	}
}
