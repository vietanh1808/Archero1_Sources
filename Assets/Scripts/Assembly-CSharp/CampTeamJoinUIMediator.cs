using System.Collections.Generic;

public class CampTeamJoinUIMediator : MediatorBase
{
	public new const string NAME = "CampTeamJoinUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampTeamJoinUIMediator()
		: base(null)
	{
	}
}
