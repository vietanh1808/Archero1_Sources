namespace TableTool
{
	public class Shop_PushTypeModel : LocalModel<Shop_PushType, int>
	{
		private const string _Filename = "Shop_PushType";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_PushType bean)
		{
			return 0;
		}
	}
}
