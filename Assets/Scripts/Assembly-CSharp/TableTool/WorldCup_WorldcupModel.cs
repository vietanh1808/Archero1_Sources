namespace TableTool
{
	public class WorldCup_WorldcupModel : LocalModel<WorldCup_Worldcup, int>
	{
		private const string _Filename = "WorldCup_Worldcup";

		protected override string Filename => null;

		protected override int GetBeanKey(WorldCup_Worldcup bean)
		{
			return 0;
		}
	}
}
