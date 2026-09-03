namespace TableTool
{
	public class Stage_Level_blessingModel : LocalModel<Stage_Level_blessing, int>
	{
		private const string _Filename = "Stage_Level_blessing";

		protected override string Filename => null;

		protected override int GetBeanKey(Stage_Level_blessing bean)
		{
			return 0;
		}
	}
}
