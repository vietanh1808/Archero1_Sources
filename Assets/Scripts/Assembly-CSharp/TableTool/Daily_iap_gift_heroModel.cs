namespace TableTool
{
	public class Daily_iap_gift_heroModel : LocalModel<Daily_iap_gift_hero, int>
	{
		private const string _Filename = "Daily_iap_gift_hero";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_iap_gift_hero bean)
		{
			return 0;
		}
	}
}
