using System.Collections.Generic;

public class GuildRankMediator : MediatorBase
{
	public new const string NAME = "GuildRankMediator";

	public override List<string> OnListNotificationInterests => null;

	public GuildRankMediator()
		: base(null)
	{
	}
}
