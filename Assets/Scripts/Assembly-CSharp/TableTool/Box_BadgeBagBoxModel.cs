namespace TableTool
{
	public class Box_BadgeBagBoxModel : LocalModel<Box_BadgeBagBox, int>
	{
		private const string _Filename = "Box_BadgeBagBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_BadgeBagBox bean)
		{
			return 0;
		}
	}
}
