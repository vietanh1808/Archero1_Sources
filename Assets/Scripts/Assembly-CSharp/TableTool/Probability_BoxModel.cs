namespace TableTool
{
	public class Probability_BoxModel : LocalModel<Probability_Box, int>
	{
		private const string _Filename = "Probability_Box";

		protected override string Filename => null;

		protected override int GetBeanKey(Probability_Box bean)
		{
			return 0;
		}
	}
}
