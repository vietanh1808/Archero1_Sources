using System.Collections.Generic;

public class PVERankMediator : MediatorBase
{
	public new const string NAME = "PVERankMediator";

	public override List<string> OnListNotificationInterests => null;

	public PVERankMediator()
		: base(null)
	{
	}
}
