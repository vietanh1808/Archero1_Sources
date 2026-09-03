using System.Collections.Generic;

public class BadgeBagOpenUIMediator : MediatorBase
{
	public new const string NAME = "BadgeBagOpenUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BadgeBagOpenUIMediator()
		: base(null)
	{
	}
}
