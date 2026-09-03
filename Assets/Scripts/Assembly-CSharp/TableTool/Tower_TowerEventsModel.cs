namespace TableTool
{
	public class Tower_TowerEventsModel : LocalModel<Tower_TowerEvents, int>
	{
		private const string _Filename = "Tower_TowerEvents";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_TowerEvents bean)
		{
			return 0;
		}
	}
}
