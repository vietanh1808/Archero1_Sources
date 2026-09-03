using System.Collections.Generic;

public class SailingShipGameResultMediator : MediatorBase
{
	public new const string NAME = "SailingShipGameResultMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingShipGameResultMediator()
		: base(null)
	{
	}
}
