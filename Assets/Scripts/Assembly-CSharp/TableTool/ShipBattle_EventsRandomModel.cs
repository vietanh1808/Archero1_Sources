namespace TableTool
{
	public class ShipBattle_EventsRandomModel : LocalModel<ShipBattle_EventsRandom, int>
	{
		private const string _Filename = "ShipBattle_EventsRandom";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_EventsRandom bean)
		{
			return 0;
		}
	}
}
