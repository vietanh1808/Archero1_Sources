using System.Collections.Generic;

public class BraveCampUIMediator : MediatorBase
{
	public new const string NAME = "BraveCampUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BraveCampUIMediator()
		: base(null)
	{
	}
}
