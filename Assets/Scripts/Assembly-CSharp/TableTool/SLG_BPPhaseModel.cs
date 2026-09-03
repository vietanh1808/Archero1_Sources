namespace TableTool
{
	public class SLG_BPPhaseModel : LocalModel<SLG_BPPhase, int>
	{
		private const string _Filename = "SLG_BPPhase";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_BPPhase bean)
		{
			return 0;
		}
	}
}
