namespace TableTool
{
	public class Fishing_ShopModel : LocalModel<Fishing_Shop, int>
	{
		private const string _Filename = "Fishing_Shop";

		protected override string Filename => null;

		protected override int GetBeanKey(Fishing_Shop bean)
		{
			return 0;
		}
	}
}
