using System.Collections.Generic;

public class DailyBackMediator : MediatorBase
{
	public new const string NAME = "DailyBackMediator";

	public override List<string> OnListNotificationInterests => null;

	public DailyBackMediator()
		: base(null)
	{
	}
}
