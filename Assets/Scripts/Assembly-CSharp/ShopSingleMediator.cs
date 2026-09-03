using System.Collections.Generic;

public class ShopSingleMediator : MediatorBase
{
	public new const string NAME = "ShopSingleMediator";

	public override List<string> OnListNotificationInterests => null;

	public ShopSingleMediator()
		: base(null)
	{
	}
}
