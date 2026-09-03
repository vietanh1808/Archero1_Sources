namespace TableTool
{
	public class Totem_TotemAttrModel : LocalModel<Totem_TotemAttr, int>
	{
		private const string _Filename = "Totem_TotemAttr";

		protected override string Filename => null;

		protected override int GetBeanKey(Totem_TotemAttr bean)
		{
			return 0;
		}
	}
}
