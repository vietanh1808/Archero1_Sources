namespace TableTool
{
	public class Probability_RandomItemModel : LocalModel<Probability_RandomItem, int>
	{
		private const string _Filename = "Probability_RandomItem";

		protected override string Filename => null;

		protected override int GetBeanKey(Probability_RandomItem bean)
		{
			return 0;
		}
	}
}
