using System.Collections.Generic;

public class VIPUIMediator : MediatorBase
{
	public new const string NAME = "VIPUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public VIPUIMediator()
		: base(null)
	{
	}
}
