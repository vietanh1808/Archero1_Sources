namespace TableTool
{
	public class ShipBattle_PhaseModel : LocalModel<ShipBattle_Phase, int>
	{
		private const string _Filename = "ShipBattle_Phase";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Phase bean)
		{
			return 0;
		}
	}
}
