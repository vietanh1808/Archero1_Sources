namespace TableTool
{
	public class Box_BlendBoxModel : LocalModel<Box_BlendBox, int>
	{
		private const string _Filename = "Box_BlendBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_BlendBox bean)
		{
			return 0;
		}
	}
}
