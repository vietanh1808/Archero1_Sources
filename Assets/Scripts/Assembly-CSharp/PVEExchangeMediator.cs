using System.Collections.Generic;

public class PVEExchangeMediator : MediatorBase
{
	public new const string NAME = "PVEExchangeMediator";

	public override List<string> OnListNotificationInterests => null;

	public PVEExchangeMediator()
		: base(null)
	{
	}
}
