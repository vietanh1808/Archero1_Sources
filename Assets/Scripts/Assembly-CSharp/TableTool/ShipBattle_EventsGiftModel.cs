namespace TableTool
{
	public class ShipBattle_EventsGiftModel : LocalModel<ShipBattle_EventsGift, int>
	{
		private const string _Filename = "ShipBattle_EventsGift";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_EventsGift bean)
		{
			return 0;
		}
	}
}
