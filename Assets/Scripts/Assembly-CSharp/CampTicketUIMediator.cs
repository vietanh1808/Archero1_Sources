using System.Collections.Generic;

public class CampTicketUIMediator : MediatorBase
{
	public new const string NAME = "CampTicketUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampTicketUIMediator()
		: base(null)
	{
	}
}
