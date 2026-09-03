namespace TableTool
{
	public class PVEStage_stagechapterModel : LocalModel<PVEStage_stagechapter, int>
	{
		private const string _Filename = "PVEStage_stagechapter";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEStage_stagechapter bean)
		{
			return 0;
		}
	}
}
