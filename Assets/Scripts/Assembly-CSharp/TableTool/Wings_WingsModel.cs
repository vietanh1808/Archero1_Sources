namespace TableTool
{
	public class Wings_WingsModel : LocalModel<Wings_Wings, int>
	{
		private const string _Filename = "Wings_Wings";

		protected override string Filename => null;

		protected override int GetBeanKey(Wings_Wings bean)
		{
			return 0;
		}
	}
}
