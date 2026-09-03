using System.Collections.Generic;

public class ShopWorkerTipsUIMediator : MediatorBase
{
	public new const string NAME = "ShopWorkerTipsUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ShopWorkerTipsUIMediator()
		: base(null)
	{
	}
}
