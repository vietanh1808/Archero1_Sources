namespace TableTool
{
	public class Equip_currencyModel : LocalModel<Equip_currency, int>
	{
		private const string _Filename = "Equip_currency";

		protected override string Filename => null;

		protected override int GetBeanKey(Equip_currency bean)
		{
			return 0;
		}
	}
}
