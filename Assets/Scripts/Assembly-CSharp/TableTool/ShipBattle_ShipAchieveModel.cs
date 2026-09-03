namespace TableTool
{
	public class ShipBattle_ShipAchieveModel : LocalModel<ShipBattle_ShipAchieve, int>
	{
		private const string _Filename = "ShipBattle_ShipAchieve";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_ShipAchieve bean)
		{
			return 0;
		}
	}
}
