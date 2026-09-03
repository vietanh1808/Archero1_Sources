using System.Collections.Generic;

public class BraveCampTaskMediator : MediatorBase
{
	public new const string NAME = "BraveCampTaskMediator";

	public override List<string> OnListNotificationInterests => null;

	public BraveCampTaskMediator()
		: base(null)
	{
	}
}
