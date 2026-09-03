namespace TableTool
{
	public class Achieve_EmployTaskModel : LocalModel<Achieve_EmployTask, int>
	{
		private const string _Filename = "Achieve_EmployTask";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_EmployTask bean)
		{
			return 0;
		}
	}
}
