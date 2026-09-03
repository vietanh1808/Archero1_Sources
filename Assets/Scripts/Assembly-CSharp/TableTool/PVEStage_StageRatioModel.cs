namespace TableTool
{
	public class PVEStage_StageRatioModel : LocalModel<PVEStage_StageRatio, int>
	{
		private const string _Filename = "PVEStage_StageRatio";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEStage_StageRatio bean)
		{
			return 0;
		}
	}
}
