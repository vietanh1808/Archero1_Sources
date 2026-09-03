namespace TableTool
{
	public class Daily_MazeNpcConfigModel : LocalModel<Daily_MazeNpcConfig, int>
	{
		private const string _Filename = "Daily_MazeNpcConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_MazeNpcConfig bean)
		{
			return 0;
		}
	}
}
