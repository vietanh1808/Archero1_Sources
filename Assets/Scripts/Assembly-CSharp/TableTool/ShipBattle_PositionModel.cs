namespace TableTool
{
	public class ShipBattle_PositionModel : LocalModel<ShipBattle_Position, int>
	{
		private const string _Filename = "ShipBattle_Position";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Position bean)
		{
			return 0;
		}
	}
}
