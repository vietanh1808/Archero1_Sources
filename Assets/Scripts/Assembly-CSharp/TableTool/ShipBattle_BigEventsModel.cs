namespace TableTool
{
	public class ShipBattle_BigEventsModel : LocalModel<ShipBattle_BigEvents, int>
	{
		private const string _Filename = "ShipBattle_BigEvents";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_BigEvents bean)
		{
			return 0;
		}
	}
}
