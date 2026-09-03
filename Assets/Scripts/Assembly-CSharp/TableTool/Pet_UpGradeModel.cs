namespace TableTool
{
	public class Pet_UpGradeModel : LocalModel<Pet_UpGrade, int>
	{
		private const string _Filename = "Pet_UpGrade";

		protected override string Filename => null;

		protected override int GetBeanKey(Pet_UpGrade bean)
		{
			return 0;
		}
	}
}
