namespace TableTool
{
	public class SLG_ShopAModel : LocalModel<SLG_ShopA, int>
	{
		private const string _Filename = "SLG_ShopA";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_ShopA bean)
		{
			return 0;
		}
	}
}
