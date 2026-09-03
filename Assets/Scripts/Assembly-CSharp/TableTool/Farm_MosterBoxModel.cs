namespace TableTool
{
	public class Farm_MosterBoxModel : LocalModel<Farm_MosterBox, int>
	{
		private const string _Filename = "Farm_MosterBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_MosterBox bean)
		{
			return 0;
		}
	}
}
