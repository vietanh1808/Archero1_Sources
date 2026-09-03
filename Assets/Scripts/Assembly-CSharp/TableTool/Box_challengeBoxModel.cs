namespace TableTool
{
	public class Box_challengeBoxModel : LocalModel<Box_challengeBox, int>
	{
		private const string _Filename = "Box_challengeBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_challengeBox bean)
		{
			return 0;
		}
	}
}
