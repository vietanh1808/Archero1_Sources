namespace TableTool
{
	public class SLG_SLGBuffModel : LocalModel<SLG_SLGBuff, int>
	{
		private const string _Filename = "SLG_SLGBuff";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_SLGBuff bean)
		{
			return 0;
		}
	}
}
