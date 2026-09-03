namespace TableTool
{
	public class Daily_BossSkillConfigModel : LocalModel<Daily_BossSkillConfig, int>
	{
		private const string _Filename = "Daily_BossSkillConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_BossSkillConfig bean)
		{
			return 0;
		}
	}
}
