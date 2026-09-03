using System.Collections.Generic;

public class ActIslandVSShopUIMediator : MediatorBase
{
	public new const string NAME = "ActIslandVSShopUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActIslandVSShopUIMediator()
		: base(null)
	{
	}
}
