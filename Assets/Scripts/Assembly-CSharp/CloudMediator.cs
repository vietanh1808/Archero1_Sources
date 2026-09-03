using System.Collections.Generic;

public class CloudMediator : MediatorBase
{
	public new const string NAME = "CloudMediator";

	public override List<string> OnListNotificationInterests => null;

	public CloudMediator()
		: base(null)
	{
	}
}
