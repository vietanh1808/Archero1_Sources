using System.Collections.Generic;

public class CommonQuickBuyUIMediator : MediatorBase
{
	public new const string NAME = "CommonQuickBuyUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CommonQuickBuyUIMediator()
		: base(null)
	{
	}
}
