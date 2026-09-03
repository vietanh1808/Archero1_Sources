using System.Collections.Generic;

public class GodWishTicketUIMediator : MediatorBase
{
	public new const string NAME = "GodWishTicketUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public GodWishTicketUIMediator()
		: base(null)
	{
	}
}
