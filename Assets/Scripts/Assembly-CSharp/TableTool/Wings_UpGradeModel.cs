namespace TableTool
{
	public class Wings_UpGradeModel : LocalModel<Wings_UpGrade, int>
	{
		private const string _Filename = "Wings_UpGrade";

		protected override string Filename => null;

		protected override int GetBeanKey(Wings_UpGrade bean)
		{
			return 0;
		}
	}
}
