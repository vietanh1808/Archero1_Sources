namespace TableTool
{
	public class Stage_Level_Hell_blessingModel : LocalModel<Stage_Level_Hell_blessing, int>
	{
		private const string _Filename = "Stage_Level_Hell_blessing";

		protected override string Filename => null;

		protected override int GetBeanKey(Stage_Level_Hell_blessing bean)
		{
			return 0;
		}
	}
}
