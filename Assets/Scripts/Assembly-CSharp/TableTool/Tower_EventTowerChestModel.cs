namespace TableTool
{
	public class Tower_EventTowerChestModel : LocalModel<Tower_EventTowerChest, int>
	{
		private const string _Filename = "Tower_EventTowerChest";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_EventTowerChest bean)
		{
			return 0;
		}
	}
}
