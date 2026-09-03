using System.Collections.Generic;

public class CampTeamGuideUIMediator : MediatorBase
{
	public new const string NAME = "CampTeamGuideUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampTeamGuideUIMediator()
		: base(null)
	{
	}
}
