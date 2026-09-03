namespace TableTool
{
	public class Imprint_BeliefModel : LocalModel<Imprint_Belief, int>
	{
		private const string _Filename = "Imprint_Belief";

		protected override string Filename => null;

		protected override int GetBeanKey(Imprint_Belief bean)
		{
			return 0;
		}
	}
}
