using System.Collections.Generic;

public class MazeBuyUIMediator : MediatorBase
{
	public new const string NAME = "MazeBuyUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MazeBuyUIMediator()
		: base(null)
	{
	}
}
