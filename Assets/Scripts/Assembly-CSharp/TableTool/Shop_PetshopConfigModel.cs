namespace TableTool
{
	public class Shop_PetshopConfigModel : LocalModel<Shop_PetshopConfig, int>
	{
		private const string _Filename = "Shop_PetshopConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_PetshopConfig bean)
		{
			return 0;
		}
	}
}
