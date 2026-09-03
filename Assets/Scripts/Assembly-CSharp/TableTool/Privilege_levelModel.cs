namespace TableTool
{
	public class Privilege_levelModel : LocalModel<Privilege_level, int>
	{
		private const string _Filename = "Privilege_level";

		protected override string Filename => null;

		protected override int GetBeanKey(Privilege_level bean)
		{
			return 0;
		}
	}
}
