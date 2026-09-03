namespace TableTool
{
	public class ShipBattle_Special3DepthModel : LocalModel<ShipBattle_Special3Depth, int>
	{
		private const string _Filename = "ShipBattle_Special3Depth";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Special3Depth bean)
		{
			return 0;
		}
	}
}
