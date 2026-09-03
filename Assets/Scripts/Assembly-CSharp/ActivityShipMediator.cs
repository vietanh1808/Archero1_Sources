using System.Collections.Generic;

public class ActivityShipMediator : MediatorBase
{
	public new const string NAME = "ActivityShipMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActivityShipMediator()
		: base(null)
	{
	}
}
