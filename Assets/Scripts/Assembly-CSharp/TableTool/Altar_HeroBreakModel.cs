namespace TableTool
{
	public class Altar_HeroBreakModel : LocalModel<Altar_HeroBreak, int>
	{
		private const string _Filename = "Altar_HeroBreak";

		protected override string Filename => null;

		protected override int GetBeanKey(Altar_HeroBreak bean)
		{
			return 0;
		}
	}
}
