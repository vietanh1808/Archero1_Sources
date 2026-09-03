using System.Collections.Generic;

public class MountainBuyUIMediator : MediatorBase
{
	public new const string NAME = "MountainBuyUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MountainBuyUIMediator()
		: base(null)
	{
	}
}
