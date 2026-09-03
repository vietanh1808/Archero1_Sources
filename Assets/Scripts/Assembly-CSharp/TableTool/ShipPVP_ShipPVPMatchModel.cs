namespace TableTool
{
	public class ShipPVP_ShipPVPMatchModel : LocalModel<ShipPVP_ShipPVPMatch, int>
	{
		private const string _Filename = "ShipPVP_ShipPVPMatch";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipPVP_ShipPVPMatch bean)
		{
			return 0;
		}
	}
}
