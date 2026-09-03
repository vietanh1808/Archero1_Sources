using System.Collections.Generic;

public class GuildGiftMediator : MediatorBase
{
	public new const string NAME = "GuildGiftMediator";

	public override List<string> OnListNotificationInterests => null;

	public GuildGiftMediator()
		: base(null)
	{
	}
}
