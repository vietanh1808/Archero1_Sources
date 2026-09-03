namespace TableTool
{
	public class Farm_EventModel : LocalModel<Farm_Event, int>
	{
		private const string _Filename = "Farm_Event";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_Event bean)
		{
			return 0;
		}
	}
}
