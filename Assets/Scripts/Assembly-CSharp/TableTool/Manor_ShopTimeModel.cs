namespace TableTool
{
	public class Manor_ShopTimeModel : LocalModel<Manor_ShopTime, int>
	{
		private const string _Filename = "Manor_ShopTime";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_ShopTime bean)
		{
			return 0;
		}
	}
}
