namespace TableTool
{
	public class WorldCup_NationModel : LocalModel<WorldCup_Nation, int>
	{
		private const string _Filename = "WorldCup_Nation";

		protected override string Filename => null;

		protected override int GetBeanKey(WorldCup_Nation bean)
		{
			return 0;
		}
	}
}
