namespace TableTool
{
	public class Imprint_ImprintModel : LocalModel<Imprint_Imprint, int>
	{
		private const string _Filename = "Imprint_Imprint";

		protected override string Filename => null;

		protected override int GetBeanKey(Imprint_Imprint bean)
		{
			return 0;
		}
	}
}
