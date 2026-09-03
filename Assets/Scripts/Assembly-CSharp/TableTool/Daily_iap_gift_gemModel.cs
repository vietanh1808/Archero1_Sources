namespace TableTool
{
	public class Daily_iap_gift_gemModel : LocalModel<Daily_iap_gift_gem, int>
	{
		private const string _Filename = "Daily_iap_gift_gem";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_iap_gift_gem bean)
		{
			return 0;
		}
	}
}
