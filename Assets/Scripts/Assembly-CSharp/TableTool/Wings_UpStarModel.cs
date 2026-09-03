namespace TableTool
{
	public class Wings_UpStarModel : LocalModel<Wings_UpStar, int>
	{
		private const string _Filename = "Wings_UpStar";

		protected override string Filename => null;

		protected override int GetBeanKey(Wings_UpStar bean)
		{
			return 0;
		}
	}
}
