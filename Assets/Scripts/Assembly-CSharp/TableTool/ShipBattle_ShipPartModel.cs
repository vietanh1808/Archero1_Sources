namespace TableTool
{
	public class ShipBattle_ShipPartModel : LocalModel<ShipBattle_ShipPart, int>
	{
		private const string _Filename = "ShipBattle_ShipPart";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_ShipPart bean)
		{
			return 0;
		}
	}
}
