namespace TableTool
{
	public class ShipBattle_EventsModel : LocalModel<ShipBattle_Events, int>
	{
		private const string _Filename = "ShipBattle_Events";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Events bean)
		{
			return 0;
		}
	}
}
