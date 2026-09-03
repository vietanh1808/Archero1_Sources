using System.Collections.Generic;

public class EventMysticMageMediator : MediatorBase
{
	public new const string NAME = "EventMysticMageMediator";

	public override List<string> OnListNotificationInterests => null;

	public EventMysticMageMediator()
		: base(null)
	{
	}
}
