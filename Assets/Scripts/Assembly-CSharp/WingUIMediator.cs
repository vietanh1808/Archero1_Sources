using System.Collections.Generic;

public class WingUIMediator : MediatorBase
{
	public new const string NAME = "WingUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public WingUIMediator()
		: base(null)
	{
	}
}
