using System.Collections.Generic;

public class MonopolyQuickBuyUIMediator : MediatorBase
{
	public new const string NAME = "MonopolyQuickBuyUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MonopolyQuickBuyUIMediator()
		: base(null)
	{
	}
}
