namespace TableTool
{
	public class ShipBattle_ShipAchieveRewardModel : LocalModel<ShipBattle_ShipAchieveReward, int>
	{
		private const string _Filename = "ShipBattle_ShipAchieveReward";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_ShipAchieveReward bean)
		{
			return 0;
		}
	}
}
