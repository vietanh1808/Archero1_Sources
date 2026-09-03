using System.Collections.Generic;

public class GemsUIMediator : MediatorBase
{
	public new const string NAME = "GemsUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public GemsUIMediator()
		: base(null)
	{
	}
}
