using System.Collections.Generic;

public class PlinkoGuideUIMediator : MediatorBase
{
	public new const string NAME = "PlinkoGuideUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PlinkoGuideUIMediator()
		: base(null)
	{
	}
}
