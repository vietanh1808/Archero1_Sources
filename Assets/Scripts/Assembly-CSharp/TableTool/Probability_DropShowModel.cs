namespace TableTool
{
	public class Probability_DropShowModel : LocalModel<Probability_DropShow, int>
	{
		private const string _Filename = "Probability_DropShow";

		protected override string Filename => null;

		protected override int GetBeanKey(Probability_DropShow bean)
		{
			return 0;
		}
	}
}
