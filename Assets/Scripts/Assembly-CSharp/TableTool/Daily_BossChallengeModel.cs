namespace TableTool
{
	public class Daily_BossChallengeModel : LocalModel<Daily_BossChallenge, int>
	{
		private const string _Filename = "Daily_BossChallenge";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_BossChallenge bean)
		{
			return 0;
		}
	}
}
