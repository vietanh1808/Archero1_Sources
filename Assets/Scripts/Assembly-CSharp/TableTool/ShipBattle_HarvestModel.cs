namespace TableTool
{
	public class ShipBattle_HarvestModel : LocalModel<ShipBattle_Harvest, int>
	{
		private const string _Filename = "ShipBattle_Harvest";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Harvest bean)
		{
			return 0;
		}
	}
}
