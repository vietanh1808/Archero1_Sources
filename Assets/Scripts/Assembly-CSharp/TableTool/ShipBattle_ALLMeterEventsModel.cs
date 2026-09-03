namespace TableTool
{
	public class ShipBattle_ALLMeterEventsModel : LocalModel<ShipBattle_ALLMeterEvents, int>
	{
		private const string _Filename = "ShipBattle_ALLMeterEvents";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_ALLMeterEvents bean)
		{
			return 0;
		}
	}
}
