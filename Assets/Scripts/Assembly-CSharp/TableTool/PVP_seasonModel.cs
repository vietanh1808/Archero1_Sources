namespace TableTool
{
	public class PVP_seasonModel : LocalModel<PVP_season, int>
	{
		private const string _Filename = "PVP_season";

		protected override string Filename => null;

		protected override int GetBeanKey(PVP_season bean)
		{
			return 0;
		}
	}
}
