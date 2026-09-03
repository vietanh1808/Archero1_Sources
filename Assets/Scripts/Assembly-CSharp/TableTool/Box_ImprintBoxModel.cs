namespace TableTool
{
	public class Box_ImprintBoxModel : LocalModel<Box_ImprintBox, int>
	{
		private const string _Filename = "Box_ImprintBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_ImprintBox bean)
		{
			return 0;
		}
	}
}
