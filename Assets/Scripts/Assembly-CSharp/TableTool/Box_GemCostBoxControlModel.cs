namespace TableTool
{
	public class Box_GemCostBoxControlModel : LocalModel<Box_GemCostBoxControl, int>
	{
		private const string _Filename = "Box_GemCostBoxControl";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_GemCostBoxControl bean)
		{
			return 0;
		}
	}
}
