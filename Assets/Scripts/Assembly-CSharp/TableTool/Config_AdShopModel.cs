namespace TableTool
{
	public class Config_AdShopModel : LocalModel<Config_AdShop, int>
	{
		private const string _Filename = "Config_AdShop";

		protected override string Filename => null;

		protected override int GetBeanKey(Config_AdShop bean)
		{
			return 0;
		}
	}
}
