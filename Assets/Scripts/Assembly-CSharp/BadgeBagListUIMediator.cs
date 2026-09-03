using System.Collections.Generic;

public class BadgeBagListUIMediator : MediatorBase
{
	public new const string NAME = "BadgeBagListUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BadgeBagListUIMediator()
		: base(null)
	{
	}
}
