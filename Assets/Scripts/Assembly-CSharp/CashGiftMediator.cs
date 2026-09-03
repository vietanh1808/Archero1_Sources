using System.Collections.Generic;

public class CashGiftMediator : MediatorBase
{
	public new const string NAME = "CashGiftMediator";

	public override List<string> OnListNotificationInterests => null;

	public CashGiftMediator()
		: base(null)
	{
	}
}
