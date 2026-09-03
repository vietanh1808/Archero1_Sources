using System.Collections.Generic;

public class GuildCreationMediator : MediatorBase
{
	public new const string NAME = "GuildCreationMediator";

	public override List<string> OnListNotificationInterests => null;

	public GuildCreationMediator()
		: base(null)
	{
	}
}
