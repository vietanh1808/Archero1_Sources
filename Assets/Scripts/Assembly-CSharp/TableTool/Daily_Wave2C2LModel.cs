namespace TableTool
{
	public class Daily_Wave2C2LModel : LocalModel<Daily_Wave2C2L, int>
	{
		private const string _Filename = "Daily_Wave2C2L";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_Wave2C2L bean)
		{
			return 0;
		}
	}
}
