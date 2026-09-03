using System.Collections.Generic;

public class ActBagLikeShopUIMediator : MediatorBase
{
	public new const string NAME = "ActBagLikeShopUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActBagLikeShopUIMediator()
		: base(null)
	{
	}
}
