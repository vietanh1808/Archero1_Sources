namespace TableTool
{
	public class Daily_HeroPartyDifficultModel : LocalModel<Daily_HeroPartyDifficult, int>
	{
		private const string _Filename = "Daily_HeroPartyDifficult";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_HeroPartyDifficult bean)
		{
			return 0;
		}
	}
}
