using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_FetterHero : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _AttHPMax;

		private ObscuredInt _AttAttack;

		private ObscuredInt[] _LevelPart;

		private ObscuredInt[] _AddAttacks;

		private ObscuredInt[] _AddHPMaxs;

		private ObscuredString _Items;

		private ObscuredString[] _LockEffect;

		private ObscuredString[] _HelpLockEffect;

		private ObscuredInt[] _HelpPer;

		private ObscuredInt[] _HeroPool;

		private ObscuredInt _MaxLevel;

		public int Id => 0;

		public int AttHPMax => 0;

		public int AttAttack => 0;

		public int[] LevelPart => null;

		public int[] AddAttacks => null;

		public int[] AddHPMaxs => null;

		public string Items => null;

		public string[] LockEffect => null;

		public string[] HelpLockEffect => null;

		public int[] HelpPer => null;

		public int[] HeroPool => null;

		public int MaxLevel => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_FetterHero Copy()
		{
			return null;
		}
	}
}
