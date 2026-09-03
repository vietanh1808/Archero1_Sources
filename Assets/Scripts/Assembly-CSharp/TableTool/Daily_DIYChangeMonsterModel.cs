namespace TableTool
{
	public class Daily_DIYChangeMonsterModel : LocalModel<Daily_DIYChangeMonster, int>
	{
		private const string _Filename = "Daily_DIYChangeMonster";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_DIYChangeMonster bean)
		{
			return 0;
		}
	}
}
