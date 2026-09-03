namespace TableTool
{
	public class Box_OpenBoxActivityModel : LocalModel<Box_OpenBoxActivity, int>
	{
		private const string _Filename = "Box_OpenBoxActivity";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_OpenBoxActivity bean)
		{
			return 0;
		}
	}
}
