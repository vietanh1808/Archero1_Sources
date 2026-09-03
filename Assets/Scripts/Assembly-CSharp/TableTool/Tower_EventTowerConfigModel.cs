namespace TableTool
{
	public class Tower_EventTowerConfigModel : LocalModel<Tower_EventTowerConfig, int>
	{
		private const string _Filename = "Tower_EventTowerConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_EventTowerConfig bean)
		{
			return 0;
		}
	}
}
