using System.Collections.Generic;

public class BadgeTaskUIMediator : MediatorBase
{
	public new const string NAME = "BadgeTaskUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BadgeTaskUIMediator()
		: base(null)
	{
	}
}
