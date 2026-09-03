namespace TableTool
{
	public class Altar_EquipUpgradeModel : LocalModel<Altar_EquipUpgrade, int>
	{
		private const string _Filename = "Altar_EquipUpgrade";

		protected override string Filename => null;

		protected override int GetBeanKey(Altar_EquipUpgrade bean)
		{
			return 0;
		}
	}
}
