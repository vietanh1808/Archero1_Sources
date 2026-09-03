using System.Collections.Generic;

public class PVEShopBuyMediator : MediatorBase
{
	public new const string NAME = "PVEShopBuyMediator";

	public override List<string> OnListNotificationInterests => null;

	public PVEShopBuyMediator()
		: base(null)
	{
	}
}
