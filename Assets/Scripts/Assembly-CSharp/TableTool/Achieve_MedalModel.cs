namespace TableTool
{
	public class Achieve_MedalModel : LocalModel<Achieve_Medal, int>
	{
		private const string _Filename = "Achieve_Medal";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_Medal bean)
		{
			return 0;
		}
	}
}
