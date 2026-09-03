namespace TableTool
{
	public class ShipBattle_SeaAnimalRewardModel : LocalModel<ShipBattle_SeaAnimalReward, int>
	{
		private const string _Filename = "ShipBattle_SeaAnimalReward";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_SeaAnimalReward bean)
		{
			return 0;
		}
	}
}
