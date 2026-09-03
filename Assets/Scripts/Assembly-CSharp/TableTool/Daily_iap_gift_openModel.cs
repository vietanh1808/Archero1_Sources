namespace TableTool
{
	public class Daily_iap_gift_openModel : LocalModel<Daily_iap_gift_open, int>
	{
		private const string _Filename = "Daily_iap_gift_open";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_iap_gift_open bean)
		{
			return 0;
		}
	}
}
