using System.Collections.Generic;

public class SailingShipPlayerInfoUIMediator : MediatorBase
{
	public new const string NAME = "SailingShipPlayerInfoUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingShipPlayerInfoUIMediator()
		: base(null)
	{
	}
}
