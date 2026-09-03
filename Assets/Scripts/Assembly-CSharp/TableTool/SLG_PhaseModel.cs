namespace TableTool
{
	public class SLG_PhaseModel : LocalModel<SLG_Phase, int>
	{
		private const string _Filename = "SLG_Phase";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_Phase bean)
		{
			return 0;
		}
	}
}
