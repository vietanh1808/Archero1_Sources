namespace TableTool
{
	public class Shop_PushModel : LocalModel<Shop_Push, int>
	{
		private const string _Filename = "Shop_Push";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_Push bean)
		{
			return 0;
		}
	}
}
