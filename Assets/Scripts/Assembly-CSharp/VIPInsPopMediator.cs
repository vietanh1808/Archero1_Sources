using System.Collections.Generic;

public class VIPInsPopMediator : MediatorBase
{
	public new const string NAME = "VIPInsPopMediator";

	public override List<string> OnListNotificationInterests => null;

	public VIPInsPopMediator()
		: base(null)
	{
	}
}
