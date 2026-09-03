using System.Collections.Generic;

public class CampTeamUIMediator : MediatorBase
{
	public new const string NAME = "CampTeamUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampTeamUIMediator()
		: base(null)
	{
	}
}
