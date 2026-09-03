using System.Collections.Generic;

public class PyramidBuyUIMediator : MediatorBase
{
	public new const string NAME = "PyramidBuyUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PyramidBuyUIMediator()
		: base(null)
	{
	}
}
