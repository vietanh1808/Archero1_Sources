namespace TableTool
{
	public class ShipBattle_BPRewardModel : LocalModel<ShipBattle_BPReward, int>
	{
		private const string _Filename = "ShipBattle_BPReward";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_BPReward bean)
		{
			return 0;
		}
	}
}
