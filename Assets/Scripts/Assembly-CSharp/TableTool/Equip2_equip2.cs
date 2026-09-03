using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip2_equip2 : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Name;

		private ObscuredInt _Position;

		private ObscuredInt _Type;

		private ObscuredInt _Icon;

		private ObscuredInt _DropIcon;

		private ObscuredString _BaseAttributes;

		private ObscuredInt _LevelBaseAttributes;

		private ObscuredString[] _AdditionSkills;

		private ObscuredInt[] _UnlockCondition;

		private ObscuredInt[] _SuperID;

		private ObscuredInt[] _CoinCost;

		public int Id => 0;

		public string Name => null;

		public int Position => 0;

		public int Type => 0;

		public int Icon => 0;

		public int DropIcon => 0;

		public string BaseAttributes => null;

		public int LevelBaseAttributes => 0;

		public string[] AdditionSkills => null;

		public int[] UnlockCondition => null;

		public int[] SuperID => null;

		public int[] CoinCost => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip2_equip2 Copy()
		{
			return null;
		}
	}
}
