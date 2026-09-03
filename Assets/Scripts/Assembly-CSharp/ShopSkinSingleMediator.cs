using System.Collections.Generic;

public class ShopSkinSingleMediator : MediatorBase
{
	public new const string NAME = "ShopSkinSingleMediator";

	public override List<string> OnListNotificationInterests => null;

	public ShopSkinSingleMediator()
		: base(null)
	{
	}
}
