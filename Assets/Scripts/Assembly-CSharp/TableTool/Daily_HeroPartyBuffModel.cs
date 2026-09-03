namespace TableTool
{
	public class Daily_HeroPartyBuffModel : LocalModel<Daily_HeroPartyBuff, int>
	{
		private const string _Filename = "Daily_HeroPartyBuff";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_HeroPartyBuff bean)
		{
			return 0;
		}
	}
}
