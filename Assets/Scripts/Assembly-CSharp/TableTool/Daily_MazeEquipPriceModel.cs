namespace TableTool
{
	public class Daily_MazeEquipPriceModel : LocalModel<Daily_MazeEquipPrice, int>
	{
		private const string _Filename = "Daily_MazeEquipPrice";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_MazeEquipPrice bean)
		{
			return 0;
		}
	}
}
