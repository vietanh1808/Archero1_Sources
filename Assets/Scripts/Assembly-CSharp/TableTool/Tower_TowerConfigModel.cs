namespace TableTool
{
	public class Tower_TowerConfigModel : LocalModel<Tower_TowerConfig, int>
	{
		private const string _Filename = "Tower_TowerConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_TowerConfig bean)
		{
			return 0;
		}
	}
}
