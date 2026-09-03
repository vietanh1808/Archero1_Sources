namespace TableTool
{
	public class Config_configModel : LocalModel<Config_config, int>
	{
		private const string _Filename = "Config_config";

		protected override string Filename => null;

		protected override int GetBeanKey(Config_config bean)
		{
			return 0;
		}

		public T GetValue<T>(int id)
		{
			return default;
		}
	}
}
