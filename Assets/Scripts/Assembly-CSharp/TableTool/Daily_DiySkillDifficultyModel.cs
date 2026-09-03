namespace TableTool
{
	public class Daily_DiySkillDifficultyModel : LocalModel<Daily_DiySkillDifficulty, int>
	{
		private const string _Filename = "Daily_DiySkillDifficulty";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_DiySkillDifficulty bean)
		{
			return 0;
		}
	}
}
