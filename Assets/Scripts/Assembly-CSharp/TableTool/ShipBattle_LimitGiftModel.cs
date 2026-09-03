namespace TableTool
{
	public class ShipBattle_LimitGiftModel : LocalModel<ShipBattle_LimitGift, int>
	{
		private const string _Filename = "ShipBattle_LimitGift";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_LimitGift bean)
		{
			return 0;
		}
	}
}
