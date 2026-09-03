using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_PVEvocation : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Vocation1;

		private ObscuredInt _Vocation2;

		private ObscuredInt _Vocation3;

		private ObscuredInt _Vocation4;

		private ObscuredInt _Vocation5;

		private ObscuredInt _Vocation6;

		private ObscuredInt _Vocation7;

		private ObscuredInt _Vocation8;

		private ObscuredInt _Vocation9;

		private ObscuredInt _Vocation10;

		public int Id => 0;

		public int Vocation1 => 0;

		public int Vocation2 => 0;

		public int Vocation3 => 0;

		public int Vocation4 => 0;

		public int Vocation5 => 0;

		public int Vocation6 => 0;

		public int Vocation7 => 0;

		public int Vocation8 => 0;

		public int Vocation9 => 0;

		public int Vocation10 => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_PVEvocation Copy()
		{
			return null;
		}
	}
}
