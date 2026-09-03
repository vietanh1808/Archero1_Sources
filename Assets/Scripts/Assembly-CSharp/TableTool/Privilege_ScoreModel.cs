namespace TableTool
{
	public class Privilege_ScoreModel : LocalModel<Privilege_Score, int>
	{
		private const string _Filename = "Privilege_Score";

		protected override string Filename => null;

		protected override int GetBeanKey(Privilege_Score bean)
		{
			return 0;
		}
	}
}
