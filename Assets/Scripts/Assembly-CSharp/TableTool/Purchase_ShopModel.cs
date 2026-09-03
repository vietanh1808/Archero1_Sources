namespace TableTool
{
	public class Purchase_ShopModel : LocalModel<Purchase_Shop, string>
	{
		private const string _Filename = "Purchase_Shop";

		protected override string Filename => null;

		protected override string GetBeanKey(Purchase_Shop bean)
		{
			return null;
		}
	}
}
