namespace TableTool
{
	public class PVEStage_DefenseTowerModel : LocalModel<PVEStage_DefenseTower, int>
	{
		private const string _Filename = "PVEStage_DefenseTower";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEStage_DefenseTower bean)
		{
			return 0;
		}
	}
}
