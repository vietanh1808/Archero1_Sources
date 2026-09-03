using System.Collections.Generic;

public class MissionUIMediator : MediatorBase
{
	public new const string NAME = "MissionUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MissionUIMediator()
		: base(null)
	{
	}
}
