using System.Collections.Generic;

public class GodWishExtendUIMediator : MediatorBase
{
	public new const string NAME = "GodWishExtendUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public GodWishExtendUIMediator()
		: base(null)
	{
	}
}
