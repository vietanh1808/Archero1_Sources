namespace TableTool
{
	public class PVEseason_vocationModel : LocalModel<PVEseason_vocation, int>
	{
		private const string _Filename = "PVEseason_vocation";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEseason_vocation bean)
		{
			return 0;
		}
	}
}
