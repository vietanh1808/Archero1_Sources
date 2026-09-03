using System.Collections.Generic;

public class BadgeActUIMediator : MediatorBase
{
	public new const string NAME = "BadgeActUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BadgeActUIMediator()
		: base(null)
	{
	}
}
