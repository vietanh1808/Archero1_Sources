namespace TableTool
{
	public class Manor_OrderModel : LocalModel<Manor_Order, int>
	{
		private const string _Filename = "Manor_Order";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_Order bean)
		{
			return 0;
		}
	}
}
