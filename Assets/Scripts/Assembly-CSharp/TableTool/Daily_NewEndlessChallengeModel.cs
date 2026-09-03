namespace TableTool
{
	public class Daily_NewEndlessChallengeModel : LocalModel<Daily_NewEndlessChallenge, int>
	{
		private const string _Filename = "Daily_NewEndlessChallenge";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_NewEndlessChallenge bean)
		{
			return 0;
		}
	}
}
