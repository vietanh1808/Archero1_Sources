using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Character_Baby : LocalBean
	{
		private ObscuredString _BabyID;

		private ObscuredInt _AttackValue;

		public string BabyID => null;

		public int AttackValue => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Character_Baby Copy()
		{
			return null;
		}
	}
}
