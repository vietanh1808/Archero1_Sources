namespace TableTool
{
	public class Equip_UpgradeModel : LocalModel<Equip_Upgrade, int>
	{
		private const string _Filename = "Equip_Upgrade";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_Upgrade bean)
		{
			return 0;
		}
	}
}
