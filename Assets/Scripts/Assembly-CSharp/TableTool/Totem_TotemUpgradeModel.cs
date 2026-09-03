namespace TableTool
{
	public class Totem_TotemUpgradeModel : LocalModel<Totem_TotemUpgrade, int>
	{
		private const string _Filename = "Totem_TotemUpgrade";

		protected override string Filename => null;

		protected override int GetBeanKey(Totem_TotemUpgrade bean)
		{
			return 0;
		}
	}
}
