namespace TableTool
{
	public class ShipBattle_NewHandModel : LocalModel<ShipBattle_NewHand, int>
	{
		private const string _Filename = "ShipBattle_NewHand";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_NewHand bean)
		{
			return 0;
		}
	}
}
