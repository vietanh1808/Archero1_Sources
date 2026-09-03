namespace TableTool
{
	public class ShipBattle_WarStepModel : LocalModel<ShipBattle_WarStep, int>
	{
		private const string _Filename = "ShipBattle_WarStep";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_WarStep bean)
		{
			return 0;
		}
	}
}
