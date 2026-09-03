namespace TableTool
{
	public class Test_AttrValueModel : LocalModel<Test_AttrValue, string>
	{
		private const string _Filename = "Test_AttrValue";

		protected override string Filename => null;

		protected override string GetBeanKey(Test_AttrValue bean)
		{
			return null;
		}
	}
}
