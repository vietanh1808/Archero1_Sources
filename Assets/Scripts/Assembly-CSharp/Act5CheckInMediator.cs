using System.Collections.Generic;

public class Act5CheckInMediator : MediatorBase
{
	public new const string NAME = "Act5CheckInMediator";

	public override List<string> OnListNotificationInterests => null;

	public Act5CheckInMediator()
		: base(null)
	{
	}
}
