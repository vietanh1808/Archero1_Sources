namespace TableTool
{
	public class ShipBattle_EventsFixedModel : LocalModel<ShipBattle_EventsFixed, int>
	{
		private const string _Filename = "ShipBattle_EventsFixed";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_EventsFixed bean)
		{
			return 0;
		}
	}
}
