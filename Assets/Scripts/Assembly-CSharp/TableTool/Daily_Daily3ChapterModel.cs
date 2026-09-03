namespace TableTool
{
	public class Daily_Daily3ChapterModel : LocalModel<Daily_Daily3Chapter, int>
	{
		private const string _Filename = "Daily_Daily3Chapter";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_Daily3Chapter bean)
		{
			return 0;
		}
	}
}
