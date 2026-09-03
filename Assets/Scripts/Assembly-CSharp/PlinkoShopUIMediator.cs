using System.Collections.Generic;

public class PlinkoShopUIMediator : MediatorBase
{
	public new const string NAME = "PlinkoShopUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PlinkoShopUIMediator()
		: base(null)
	{
	}
}
