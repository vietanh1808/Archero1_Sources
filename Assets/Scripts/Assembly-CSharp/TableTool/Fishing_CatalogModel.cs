namespace TableTool
{
	public class Fishing_CatalogModel : LocalModel<Fishing_Catalog, int>
	{
		private const string _Filename = "Fishing_Catalog";

		protected override string Filename => null;

		protected override int GetBeanKey(Fishing_Catalog bean)
		{
			return 0;
		}
	}
}
