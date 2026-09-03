namespace TableTool
{
	public class PVEStage_MonsterModel : LocalModel<PVEStage_Monster, int>
	{
		private const string _Filename = "PVEStage_Monster";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEStage_Monster bean)
		{
			return 0;
		}
	}
}
