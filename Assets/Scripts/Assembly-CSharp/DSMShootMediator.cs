using System.Collections.Generic;

public class DSMShootMediator : MediatorBase
{
	public new const string NAME = "DSMShootMediator";

	public override List<string> OnListNotificationInterests => null;

	public DSMShootMediator()
		: base(null)
	{
	}
}
