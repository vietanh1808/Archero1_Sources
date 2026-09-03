using System.Collections.Generic;

public class BadgeBagUpUIMediator : MediatorBase
{
	public new const string NAME = "BadgeBagUpUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BadgeBagUpUIMediator()
		: base(null)
	{
	}
}
