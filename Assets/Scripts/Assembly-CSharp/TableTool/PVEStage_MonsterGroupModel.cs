namespace TableTool
{
	public class PVEStage_MonsterGroupModel : LocalModel<PVEStage_MonsterGroup, int>
	{
		private const string _Filename = "PVEStage_MonsterGroup";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEStage_MonsterGroup bean)
		{
			return 0;
		}
	}
}
