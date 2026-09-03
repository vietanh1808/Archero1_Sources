using System.Collections.Generic;

public class GiftBoxMediator : MediatorBase
{
	public new const string NAME = "GiftBoxMediator";

	public override List<string> OnListNotificationInterests => null;

	public GiftBoxMediator()
		: base(null)
	{
	}
}
