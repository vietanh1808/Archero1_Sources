namespace TableTool
{
	public class Daily_Maze_SmithyShopModel : LocalModel<Daily_Maze_SmithyShop, int>
	{
		private const string _Filename = "Daily_Maze_SmithyShop";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_Maze_SmithyShop bean)
		{
			return 0;
		}
	}
}
