using System.Collections.Generic;

public class DailyTDInfoMediator : MediatorBase
{
	public new const string NAME = "DailyTDInfoMediator";

	public override List<string> OnListNotificationInterests => null;

	public DailyTDInfoMediator()
		: base(null)
	{
	}
}
