namespace TableTool
{
	public class Daily_Wave3C2LModel : LocalModel<Daily_Wave3C2L, int>
	{
		private const string _Filename = "Daily_Wave3C2L";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_Wave3C2L bean)
		{
			return 0;
		}
	}
}
