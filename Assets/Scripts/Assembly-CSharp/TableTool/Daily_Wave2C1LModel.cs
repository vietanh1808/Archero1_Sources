namespace TableTool
{
	public class Daily_Wave2C1LModel : LocalModel<Daily_Wave2C1L, int>
	{
		private const string _Filename = "Daily_Wave2C1L";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_Wave2C1L bean)
		{
			return 0;
		}
	}
}
