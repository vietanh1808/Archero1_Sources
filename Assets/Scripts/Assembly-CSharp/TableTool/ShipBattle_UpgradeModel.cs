namespace TableTool
{
	public class ShipBattle_UpgradeModel : LocalModel<ShipBattle_Upgrade, int>
	{
		private const string _Filename = "ShipBattle_Upgrade";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipBattle_Upgrade bean)
		{
			return 0;
		}
	}
}
