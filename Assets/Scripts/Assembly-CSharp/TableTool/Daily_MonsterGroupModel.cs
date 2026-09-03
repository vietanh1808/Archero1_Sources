namespace TableTool
{
	public class Daily_MonsterGroupModel : LocalModel<Daily_MonsterGroup, int>
	{
		private const string _Filename = "Daily_MonsterGroup";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_MonsterGroup bean)
		{
			return 0;
		}
	}
}
