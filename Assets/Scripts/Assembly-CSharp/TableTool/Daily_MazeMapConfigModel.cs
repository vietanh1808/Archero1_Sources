namespace TableTool
{
	public class Daily_MazeMapConfigModel : LocalModel<Daily_MazeMapConfig, int>
	{
		private const string _Filename = "Daily_MazeMapConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_MazeMapConfig bean)
		{
			return 0;
		}
	}
}
