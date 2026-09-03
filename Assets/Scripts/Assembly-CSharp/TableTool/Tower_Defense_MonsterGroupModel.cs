namespace TableTool
{
	public class Tower_Defense_MonsterGroupModel : LocalModel<Tower_Defense_MonsterGroup, int>
	{
		private const string _Filename = "Tower_Defense_MonsterGroup";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_Defense_MonsterGroup bean)
		{
			return 0;
		}
	}
}
