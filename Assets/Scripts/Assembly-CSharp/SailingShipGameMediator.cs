using System.Collections.Generic;

public class SailingShipGameMediator : MediatorBase
{
	public new const string NAME = "SailingShipGameMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingShipGameMediator()
		: base(null)
	{
	}
}
