namespace TableTool
{
	public class SLG_HeroDispatchModel : LocalModel<SLG_HeroDispatch, int>
	{
		private const string _Filename = "SLG_HeroDispatch";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_HeroDispatch bean)
		{
			return 0;
		}
	}
}
