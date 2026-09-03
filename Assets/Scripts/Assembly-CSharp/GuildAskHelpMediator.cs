using System.Collections.Generic;

public class GuildAskHelpMediator : MediatorBase
{
	public new const string NAME = "GuildAskHelpMediator";

	public override List<string> OnListNotificationInterests => null;

	public GuildAskHelpMediator()
		: base(null)
	{
	}
}
