namespace TableTool
{
	public class Box_GiftBoxModel : LocalModel<Box_GiftBox, int>
	{
		private const string _Filename = "Box_GiftBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_GiftBox bean)
		{
			return 0;
		}
	}
}
