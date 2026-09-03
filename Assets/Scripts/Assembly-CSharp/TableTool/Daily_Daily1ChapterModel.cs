namespace TableTool
{
	public class Daily_Daily1ChapterModel : LocalModel<Daily_Daily1Chapter, int>
	{
		private const string _Filename = "Daily_Daily1Chapter";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_Daily1Chapter bean)
		{
			return 0;
		}
	}
}
