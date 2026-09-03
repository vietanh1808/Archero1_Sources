namespace TableTool
{
	public class Achieve_AssignmentModel : LocalModel<Achieve_Assignment, int>
	{
		private const string _Filename = "Achieve_Assignment";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_Assignment bean)
		{
			return 0;
		}
	}
}
