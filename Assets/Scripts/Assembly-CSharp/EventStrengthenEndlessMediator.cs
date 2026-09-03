using System.Collections.Generic;

public class EventStrengthenEndlessMediator : MediatorBase
{
	public new const string NAME = "EventStrengthenEndlessMediator";

	public override List<string> OnListNotificationInterests => null;

	public EventStrengthenEndlessMediator()
		: base(null)
	{
	}
}
