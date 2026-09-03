namespace TableTool
{
	public class Tower_EventTowerTimeModel : LocalModel<Tower_EventTowerTime, int>
	{
		private const string _Filename = "Tower_EventTowerTime";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_EventTowerTime bean)
		{
			return 0;
		}
	}
}
