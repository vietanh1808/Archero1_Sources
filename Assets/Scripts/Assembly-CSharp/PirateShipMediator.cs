using System.Collections.Generic;

public class PirateShipMediator : MediatorBase
{
	public new const string NAME = "PirateShipMediator";

	public override List<string> OnListNotificationInterests => null;

	public PirateShipMediator()
		: base(null)
	{
	}
}
