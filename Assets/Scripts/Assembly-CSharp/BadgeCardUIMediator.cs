using System.Collections.Generic;

public class BadgeCardUIMediator : MediatorBase
{
	public new const string NAME = "BadgeCardUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BadgeCardUIMediator()
		: base(null)
	{
	}
}
