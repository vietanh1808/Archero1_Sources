namespace TableTool
{
	public class ShipPVP_ShipPVPModel : LocalModel<ShipPVP_ShipPVP, int>
	{
		private const string _Filename = "ShipPVP_ShipPVP";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipPVP_ShipPVP bean)
		{
			return 0;
		}
	}
}
