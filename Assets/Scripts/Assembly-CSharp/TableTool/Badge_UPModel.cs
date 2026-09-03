namespace TableTool
{
	public class Badge_UPModel : LocalModel<Badge_UP, int>
	{
		private const string _Filename = "Badge_UP";

		protected override string Filename => null;

		protected override int GetBeanKey(Badge_UP bean)
		{
			return 0;
		}
	}
}
