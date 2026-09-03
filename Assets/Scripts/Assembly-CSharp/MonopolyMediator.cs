using System.Collections.Generic;

public class MonopolyMediator : MediatorBase
{
	public new const string NAME = "MonopolyMediator";

	public override List<string> OnListNotificationInterests => null;

	public MonopolyMediator()
		: base(null)
	{
	}
}
