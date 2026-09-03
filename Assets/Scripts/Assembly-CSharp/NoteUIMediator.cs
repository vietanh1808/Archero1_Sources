using System.Collections.Generic;

public class NoteUIMediator : MediatorBase
{
	public new const string NAME = "NoteUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public NoteUIMediator()
		: base(null)
	{
	}
}
