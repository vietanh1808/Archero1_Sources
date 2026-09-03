namespace TableTool
{
	public class Stage_Level_Hell_guardModel : LocalModel<Stage_Level_Hell_guard, int>
	{
		private const string _Filename = "Stage_Level_Hell_guard";

		protected override string Filename => null;

		protected override int GetBeanKey(Stage_Level_Hell_guard bean)
		{
			return 0;
		}
	}
}
