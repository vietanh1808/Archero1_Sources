namespace TableTool
{
	public class Daily_ChangeMonsterConfigModel : LocalModel<Daily_ChangeMonsterConfig, int>
	{
		private const string _Filename = "Daily_ChangeMonsterConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_ChangeMonsterConfig bean)
		{
			return 0;
		}
	}
}
