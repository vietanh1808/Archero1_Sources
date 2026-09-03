namespace TableTool
{
	public class ShipBattle_GiftModel : LocalModel<ShipBattle_Gift, int>
	{
		private const string _Filename = "ShipBattle_Gift";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Gift bean)
		{
			return 0;
		}
	}
}
