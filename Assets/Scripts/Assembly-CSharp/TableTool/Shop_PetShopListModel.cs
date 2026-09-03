namespace TableTool
{
	public class Shop_PetShopListModel : LocalModel<Shop_PetShopList, int>
	{
		private const string _Filename = "Shop_PetShopList";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_PetShopList bean)
		{
			return 0;
		}
	}
}
