using System.Collections.Generic;

public class SailingGuideUIMediator : MediatorBase
{
	public new const string NAME = "SailingGuideUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingGuideUIMediator()
		: base(null)
	{
	}
}
