namespace TableTool
{
	public class Tower_Defense_DefenseTowerModel : LocalModel<Tower_Defense_DefenseTower, int>
	{
		private const string _Filename = "Tower_Defense_DefenseTower";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_Defense_DefenseTower bean)
		{
			return 0;
		}
	}
}
