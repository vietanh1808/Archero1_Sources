namespace TableTool
{
	public class ShipBattle_PreviewRewardModel : LocalModel<ShipBattle_PreviewReward, int>
	{
		private const string _Filename = "ShipBattle_PreviewReward";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_PreviewReward bean)
		{
			return 0;
		}
	}
}
