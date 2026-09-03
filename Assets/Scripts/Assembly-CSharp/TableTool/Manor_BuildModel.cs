namespace TableTool
{
	public class Manor_BuildModel : LocalModel<Manor_Build, int>
	{
		private const string _Filename = "Manor_Build";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_Build bean)
		{
			return 0;
		}
	}
}
