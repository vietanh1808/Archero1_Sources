namespace TableTool
{
	public class Config_ActivityDeleteItemModel : LocalModel<Config_ActivityDeleteItem, int>
	{
		private const string _Filename = "Config_ActivityDeleteItem";

		protected override string Filename => null;

		protected override int GetBeanKey(Config_ActivityDeleteItem bean)
		{
			return 0;
		}
	}
}
