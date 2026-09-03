namespace TableTool
{
	public class PVEseason_timeModel : LocalModel<PVEseason_time, int>
	{
		private const string _Filename = "PVEseason_time";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEseason_time bean)
		{
			return 0;
		}
	}
}
