using System.Collections.Generic;

public class BagUIMediator : MediatorBase
{
	public new const string NAME = "BagUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BagUIMediator()
		: base(null)
	{
	}
}
