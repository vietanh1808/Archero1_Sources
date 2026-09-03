namespace TableTool
{
	public class SLG_BaseLevelModel : LocalModel<SLG_BaseLevel, int>
	{
		private const string _Filename = "SLG_BaseLevel";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_BaseLevel bean)
		{
			return 0;
		}
	}
}
