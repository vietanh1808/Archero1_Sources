namespace TableTool
{
	public class Box_GemCostBoxModel : LocalModel<Box_GemCostBox, int>
	{
		private const string _Filename = "Box_GemCostBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_GemCostBox bean)
		{
			return 0;
		}
	}
}
