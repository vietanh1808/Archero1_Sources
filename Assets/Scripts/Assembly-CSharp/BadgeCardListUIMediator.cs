using System.Collections.Generic;

public class BadgeCardListUIMediator : MediatorBase
{
	public new const string NAME = "BadgeCardListUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BadgeCardListUIMediator()
		: base(null)
	{
	}
}
