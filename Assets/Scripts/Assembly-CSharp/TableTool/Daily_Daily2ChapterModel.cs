namespace TableTool
{
	public class Daily_Daily2ChapterModel : LocalModel<Daily_Daily2Chapter, int>
	{
		private const string _Filename = "Daily_Daily2Chapter";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_Daily2Chapter bean)
		{
			return 0;
		}
	}
}
