namespace TableTool
{
	public class Farm_SmallGameModel : LocalModel<Farm_SmallGame, int>
	{
		private const string _Filename = "Farm_SmallGame";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_SmallGame bean)
		{
			return 0;
		}
	}
}
