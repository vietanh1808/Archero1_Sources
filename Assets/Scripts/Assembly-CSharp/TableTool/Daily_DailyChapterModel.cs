namespace TableTool
{
	public class Daily_DailyChapterModel : LocalModel<Daily_DailyChapter, int>
	{
		private const string _Filename = "Daily_DailyChapter";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_DailyChapter bean)
		{
			return 0;
		}
	}
}
