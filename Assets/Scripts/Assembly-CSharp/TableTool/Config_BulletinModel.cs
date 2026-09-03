namespace TableTool
{
	public class Config_BulletinModel : LocalModel<Config_Bulletin, int>
	{
		private const string _Filename = "Config_Bulletin";

		protected override string Filename => null;

		protected override int GetBeanKey(Config_Bulletin bean)
		{
			return 0;
		}
	}
}
