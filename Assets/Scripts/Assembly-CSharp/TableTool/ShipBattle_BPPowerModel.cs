namespace TableTool
{
	public class ShipBattle_BPPowerModel : LocalModel<ShipBattle_BPPower, int>
	{
		private const string _Filename = "ShipBattle_BPPower";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_BPPower bean)
		{
			return 0;
		}
	}
}
