using System.Collections.Generic;

public class MonopolyShopUIMediator : MediatorBase
{
	public new const string NAME = "MonopolyShopUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MonopolyShopUIMediator()
		: base(null)
	{
	}
}
