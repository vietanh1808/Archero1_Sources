namespace TableTool
{
	public class ShipPVP_ShipPVPRewardModel : LocalModel<ShipPVP_ShipPVPReward, int>
	{
		private const string _Filename = "ShipPVP_ShipPVPReward";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipPVP_ShipPVPReward bean)
		{
			return 0;
		}
	}
}
