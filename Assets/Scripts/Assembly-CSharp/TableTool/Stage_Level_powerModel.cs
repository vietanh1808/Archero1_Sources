namespace TableTool
{
	public class Stage_Level_powerModel : LocalModel<Stage_Level_power, int>
	{
		private const string _Filename = "Stage_Level_power";

		protected override string Filename => null;

		protected override int GetBeanKey(Stage_Level_power bean)
		{
			return 0;
		}
	}
}
