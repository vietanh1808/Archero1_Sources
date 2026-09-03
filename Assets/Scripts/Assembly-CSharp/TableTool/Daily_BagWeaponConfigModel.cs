namespace TableTool
{
	public class Daily_BagWeaponConfigModel : LocalModel<Daily_BagWeaponConfig, int>
	{
		private const string _Filename = "Daily_BagWeaponConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_BagWeaponConfig bean)
		{
			return 0;
		}
	}
}
