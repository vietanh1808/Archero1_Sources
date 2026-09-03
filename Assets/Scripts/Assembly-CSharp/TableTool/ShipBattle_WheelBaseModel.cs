namespace TableTool
{
	public class ShipBattle_WheelBaseModel : LocalModel<ShipBattle_WheelBase, int>
	{
		private const string _Filename = "ShipBattle_WheelBase";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_WheelBase bean)
		{
			return 0;
		}
	}
}
