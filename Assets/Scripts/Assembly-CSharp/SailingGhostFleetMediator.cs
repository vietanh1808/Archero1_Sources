using System.Collections.Generic;

public class SailingGhostFleetMediator : MediatorBase
{
	public new const string NAME = "SailingShipGameResultMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingGhostFleetMediator()
		: base(null)
	{
	}
}
