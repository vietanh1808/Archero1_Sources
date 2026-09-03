using System.Collections.Generic;

public class BadgeAbilityGetUIMediator : MediatorBase
{
	public new const string NAME = "BadgeAbilityGetUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BadgeAbilityGetUIMediator()
		: base(null)
	{
	}
}
