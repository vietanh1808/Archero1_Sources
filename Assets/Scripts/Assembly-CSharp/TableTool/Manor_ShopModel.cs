namespace TableTool
{
	public class Manor_ShopModel : LocalModel<Manor_Shop, int>
	{
		private const string _Filename = "Manor_Shop";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_Shop bean)
		{
			return 0;
		}
	}
}
