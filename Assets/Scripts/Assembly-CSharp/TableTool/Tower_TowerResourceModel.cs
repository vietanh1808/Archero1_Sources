namespace TableTool
{
	public class Tower_TowerResourceModel : LocalModel<Tower_TowerResource, int>
	{
		private const string _Filename = "Tower_TowerResource";

		protected override string Filename => null;

		protected override int GetBeanKey(Tower_TowerResource bean)
		{
			return 0;
		}
	}
}
