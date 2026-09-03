namespace TableTool
{
	public class ShipBattle_MobilizationRewardModel : LocalModel<ShipBattle_MobilizationReward, int>
	{
		private const string _Filename = "ShipBattle_MobilizationReward";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_MobilizationReward bean)
		{
			return 0;
		}
	}
}
