namespace TableTool
{
	public class ShipBattle_EventsActionModel : LocalModel<ShipBattle_EventsAction, int>
	{
		private const string _Filename = "ShipBattle_EventsAction";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_EventsAction bean)
		{
			return 0;
		}
	}
}
