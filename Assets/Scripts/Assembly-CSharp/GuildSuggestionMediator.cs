using System.Collections.Generic;

public class GuildSuggestionMediator : MediatorBase
{
	public new const string NAME = "GuildSuggestionMediator";

	public override List<string> OnListNotificationInterests => null;

	public GuildSuggestionMediator()
		: base(null)
	{
	}
}
