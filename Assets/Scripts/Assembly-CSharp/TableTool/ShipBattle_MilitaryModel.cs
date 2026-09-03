namespace TableTool
{
	public class ShipBattle_MilitaryModel : LocalModel<ShipBattle_Military, int>
	{
		private const string _Filename = "ShipBattle_Military";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Military bean)
		{
			return 0;
		}
	}
}
