using System.Collections.Generic;

public class CampKeyBuyUIMediator : MediatorBase
{
	public new const string NAME = "CampKeyBuyUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampKeyBuyUIMediator()
		: base(null)
	{
	}
}
