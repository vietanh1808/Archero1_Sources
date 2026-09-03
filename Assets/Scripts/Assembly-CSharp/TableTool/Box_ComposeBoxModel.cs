namespace TableTool
{
	public class Box_ComposeBoxModel : LocalModel<Box_ComposeBox, int>
	{
		private const string _Filename = "Box_ComposeBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_ComposeBox bean)
		{
			return 0;
		}
	}
}
