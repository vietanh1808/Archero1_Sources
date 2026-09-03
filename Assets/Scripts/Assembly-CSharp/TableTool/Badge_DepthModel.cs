namespace TableTool
{
	public class Badge_DepthModel : LocalModel<Badge_Depth, int>
	{
		private const string _Filename = "Badge_Depth";

		protected override string Filename => null;

		protected override int GetBeanKey(Badge_Depth bean)
		{
			return 0;
		}
	}
}
