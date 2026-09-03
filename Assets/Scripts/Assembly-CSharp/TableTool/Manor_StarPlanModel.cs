namespace TableTool
{
	public class Manor_StarPlanModel : LocalModel<Manor_StarPlan, int>
	{
		private const string _Filename = "Manor_StarPlan";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_StarPlan bean)
		{
			return 0;
		}
	}
}
