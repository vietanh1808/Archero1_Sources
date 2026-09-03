namespace TableTool
{
	public class WorldCup_WorldCupShopModel : LocalModel<WorldCup_WorldCupShop, int>
	{
		private const string _Filename = "WorldCup_WorldCupShop";

		protected override string Filename => null;

		protected override int GetBeanKey(WorldCup_WorldCupShop bean)
		{
			return 0;
		}
	}
}
