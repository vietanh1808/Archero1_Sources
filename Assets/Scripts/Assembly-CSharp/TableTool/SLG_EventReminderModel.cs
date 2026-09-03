namespace TableTool
{
	public class SLG_EventReminderModel : LocalModel<SLG_EventReminder, int>
	{
		private const string _Filename = "SLG_EventReminder";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_EventReminder bean)
		{
			return 0;
		}
	}
}
