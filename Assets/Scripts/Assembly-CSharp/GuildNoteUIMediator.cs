using System.Collections.Generic;

public class GuildNoteUIMediator : MediatorBase
{
	public new const string NAME = "GuildNoteUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public GuildNoteUIMediator()
		: base(null)
	{
	}
}
