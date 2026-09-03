namespace TableTool
{
	public class SLG_ShopBModel : LocalModel<SLG_ShopB, int>
	{
		private const string _Filename = "SLG_ShopB";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_ShopB bean)
		{
			return 0;
		}
	}
}
