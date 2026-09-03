namespace TableTool
{
	public class ShipBattle_EventsGuarantModel : LocalModel<ShipBattle_EventsGuarant, int>
	{
		private const string _Filename = "ShipBattle_EventsGuarant";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_EventsGuarant bean)
		{
			return 0;
		}
	}
}
