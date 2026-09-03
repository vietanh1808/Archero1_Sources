namespace TableTool
{
	public class Config_AdListModel : LocalModel<Config_AdList, int>
	{
		private const string _Filename = "Config_AdList";

		protected override string Filename => null;

		protected override int GetBeanKey(Config_AdList bean)
		{
			return 0;
		}
	}
}
