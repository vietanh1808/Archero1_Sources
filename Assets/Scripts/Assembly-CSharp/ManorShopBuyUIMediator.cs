using System.Collections.Generic;

public class ManorShopBuyUIMediator : MediatorBase
{
	public new const string NAME = "ManorShopBuyUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorShopBuyUIMediator()
		: base(null)
	{
	}
}
