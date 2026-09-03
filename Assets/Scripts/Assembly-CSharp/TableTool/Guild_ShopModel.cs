namespace TableTool
{
	public class Guild_ShopModel : LocalModel<Guild_Shop, int>
	{
		private const string _Filename = "Guild_Shop";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_Shop bean)
		{
			return 0;
		}
	}
}
