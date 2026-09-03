namespace TableTool
{
	public class WorldCup_WorldTaskModel : LocalModel<WorldCup_WorldTask, int>
	{
		private const string _Filename = "WorldCup_WorldTask";

		protected override string Filename => null;

		protected override int GetBeanKey(WorldCup_WorldTask bean)
		{
			return 0;
		}
	}
}
