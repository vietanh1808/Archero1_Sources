namespace TableTool
{
	public class ShipBattle_MultipleEventsModel : LocalModel<ShipBattle_MultipleEvents, int>
	{
		private const string _Filename = "ShipBattle_MultipleEvents";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_MultipleEvents bean)
		{
			return 0;
		}
	}
}
