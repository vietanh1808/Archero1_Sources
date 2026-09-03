namespace TableTool
{
	public class ShipBattle_WheelRewardModel : LocalModel<ShipBattle_WheelReward, int>
	{
		private const string _Filename = "ShipBattle_WheelReward";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_WheelReward bean)
		{
			return 0;
		}
	}
}
