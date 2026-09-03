namespace TableTool
{
	public class ShipBattle_Special1DepthModel : LocalModel<ShipBattle_Special1Depth, int>
	{
		private const string _Filename = "ShipBattle_Special1Depth";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Special1Depth bean)
		{
			return 0;
		}
	}
}
