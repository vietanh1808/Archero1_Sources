using System.Collections.Generic;

public class MiningShopUIMediator : MediatorBase
{
	public new const string NAME = "MiningShopUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MiningShopUIMediator()
		: base(null)
	{
	}
}
