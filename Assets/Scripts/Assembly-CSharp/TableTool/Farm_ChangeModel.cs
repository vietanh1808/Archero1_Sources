namespace TableTool
{
	public class Farm_ChangeModel : LocalModel<Farm_Change, int>
	{
		private const string _Filename = "Farm_Change";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_Change bean)
		{
			return 0;
		}
	}
}
