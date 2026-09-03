namespace TableTool
{
	public class Daily_DiySkillEquipsModel : LocalModel<Daily_DiySkillEquips, int>
	{
		private const string _Filename = "Daily_DiySkillEquips";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_DiySkillEquips bean)
		{
			return 0;
		}
	}
}
