namespace TableTool
{
	public class Daily_DefenseTowerModel : LocalModel<Daily_DefenseTower, int>
	{
		private const string _Filename = "Daily_DefenseTower";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_DefenseTower bean)
		{
			return 0;
		}
	}
}
