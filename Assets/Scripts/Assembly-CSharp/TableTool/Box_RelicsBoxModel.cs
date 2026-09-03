namespace TableTool
{
	public class Box_RelicsBoxModel : LocalModel<Box_RelicsBox, int>
	{
		private const string _Filename = "Box_RelicsBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_RelicsBox bean)
		{
			return 0;
		}
	}
}
