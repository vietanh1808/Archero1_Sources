namespace TableTool
{
	public class ShipBattle_BoxModel : LocalModel<ShipBattle_Box, int>
	{
		private const string _Filename = "ShipBattle_Box";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Box bean)
		{
			return 0;
		}
	}
}
