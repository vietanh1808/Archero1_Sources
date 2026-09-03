namespace TableTool
{
	public class Tower_Defense_MonsterModel : LocalModel<Tower_Defense_Monster, int>
	{
		private const string _Filename = "Tower_Defense_Monster";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_Defense_Monster bean)
		{
			return 0;
		}
	}
}
