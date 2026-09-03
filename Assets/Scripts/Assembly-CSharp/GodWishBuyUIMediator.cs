using System.Collections.Generic;

public class GodWishBuyUIMediator : MediatorBase
{
	public new const string NAME = "GodWishBuyUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public GodWishBuyUIMediator()
		: base(null)
	{
	}
}
