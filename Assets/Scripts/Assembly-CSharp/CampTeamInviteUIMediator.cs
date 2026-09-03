using System.Collections.Generic;

public class CampTeamInviteUIMediator : MediatorBase
{
	public new const string NAME = "CampTeamInviteUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampTeamInviteUIMediator()
		: base(null)
	{
	}
}
