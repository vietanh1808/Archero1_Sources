namespace TableTool
{
	public class Config_AttrForTestModel : LocalModel<Config_AttrForTest, int>
	{
		private const string _Filename = "Config_AttrForTest";

		protected override string Filename => null;

		protected override int GetBeanKey(Config_AttrForTest bean)
		{
			return 0;
		}
	}
}
