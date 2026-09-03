using System.Collections.Generic;

public class BadgeTagListUIMediator : MediatorBase
{
	public new const string NAME = "BadgeTagListUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BadgeTagListUIMediator()
		: base(null)
	{
	}
}
