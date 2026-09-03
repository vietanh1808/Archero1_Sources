using System.Collections.Generic;

public class EventMagicianMediator : MediatorBase
{
	public new const string NAME = "EventGridGachaMediator";

	public override List<string> OnListNotificationInterests => null;

	public EventMagicianMediator()
		: base(null)
	{
	}
}
