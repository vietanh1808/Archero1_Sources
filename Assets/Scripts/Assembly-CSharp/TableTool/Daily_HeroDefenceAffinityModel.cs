namespace TableTool
{
	public class Daily_HeroDefenceAffinityModel : LocalModel<Daily_HeroDefenceAffinity, int>
	{
		private const string _Filename = "Daily_HeroDefenceAffinity";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_HeroDefenceAffinity bean)
		{
			return 0;
		}
	}
}
