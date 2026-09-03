using System.Collections.Generic;

public class MiningGuideUIMediator : MediatorBase
{
	public new const string NAME = "MiningGuideUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MiningGuideUIMediator()
		: base(null)
	{
	}
}
