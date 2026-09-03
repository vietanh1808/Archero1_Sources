using System.Collections.Generic;

public class GuildHelpMediator : MediatorBase
{
	public new const string NAME = "GuildHelpMediator";

	public override List<string> OnListNotificationInterests => null;

	public GuildHelpMediator()
		: base(null)
	{
	}
}
