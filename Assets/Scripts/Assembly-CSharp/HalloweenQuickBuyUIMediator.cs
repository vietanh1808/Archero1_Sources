using System.Collections.Generic;

public class HalloweenQuickBuyUIMediator : MediatorBase
{
	public new const string NAME = "HalloweenQuickBuyUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public HalloweenQuickBuyUIMediator()
		: base(null)
	{
	}
}
