namespace TableTool
{
	public class ShipStage_BagWeaponModel : LocalModel<ShipStage_BagWeapon, int>
	{
		private const string _Filename = "ShipStage_BagWeapon";

		protected override string Filename => null;

		protected override int GetBeanKey(ShipStage_BagWeapon bean)
		{
			return 0;
		}
	}
}
