using System.Collections.Generic;

public class SlotMediator : MediatorBase
{
	public new const string NAME = "SlotMediator";

	public override List<string> OnListNotificationInterests => null;

	public SlotMediator()
		: base(null)
	{
	}
}
