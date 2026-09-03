using System.Collections.Generic;

public class GuildUIMediator : MediatorBase
{
	public new const string NAME = "GuildUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public GuildUIMediator()
		: base(null)
	{
	}
}
