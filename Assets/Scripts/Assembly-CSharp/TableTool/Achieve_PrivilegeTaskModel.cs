namespace TableTool
{
	public class Achieve_PrivilegeTaskModel : LocalModel<Achieve_PrivilegeTask, int>
	{
		private const string _Filename = "Achieve_PrivilegeTask";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_PrivilegeTask bean)
		{
			return 0;
		}
	}
}
