using System.Collections.Generic;

public class HalloweenUIMediator : MediatorBase
{
	public new const string NAME = "HalloweenUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public HalloweenUIMediator()
		: base(null)
	{
	}
}
