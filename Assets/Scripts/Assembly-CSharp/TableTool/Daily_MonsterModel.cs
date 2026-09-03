namespace TableTool
{
	public class Daily_MonsterModel : LocalModel<Daily_Monster, int>
	{
		private const string _Filename = "Daily_Monster";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_Monster bean)
		{
			return 0;
		}
	}
}
