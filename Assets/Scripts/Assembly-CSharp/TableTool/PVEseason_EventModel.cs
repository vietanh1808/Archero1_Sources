namespace TableTool
{
	public class PVEseason_EventModel : LocalModel<PVEseason_Event, int>
	{
		private const string _Filename = "PVEseason_Event";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEseason_Event bean)
		{
			return 0;
		}
	}
}
