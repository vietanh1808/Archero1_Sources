namespace TableTool
{
	public class Daily_HeroDefenceChallengeModel : LocalModel<Daily_HeroDefenceChallenge, int>
	{
		private const string _Filename = "Daily_HeroDefenceChallenge";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_HeroDefenceChallenge bean)
		{
			return 0;
		}
	}
}
