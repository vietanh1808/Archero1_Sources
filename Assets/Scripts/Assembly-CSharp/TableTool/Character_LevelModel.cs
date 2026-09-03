namespace TableTool
{
	public class Character_LevelModel : LocalModel<Character_Level, int>
	{
		private const string _Filename = "Character_Level";

		private int maxLevel;

		protected override string Filename => null;

		protected override int GetBeanKey(Character_Level bean)
		{
			return 0;
		}

		public void Init()
		{
		}

		public int GetExp(int level)
		{
			return 0;
		}

		public int GetMaxLevel()
		{
			return 0;
		}

		public int GetLevelUpCount(int addexp)
		{
			return 0;
		}
	}
}
