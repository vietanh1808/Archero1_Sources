using System.Collections.Generic;

public class ShopBoxTipsUIMediator : MediatorBase
{
	public new const string NAME = "ShopBoxTipsUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ShopBoxTipsUIMediator()
		: base(null)
	{
	}
}
