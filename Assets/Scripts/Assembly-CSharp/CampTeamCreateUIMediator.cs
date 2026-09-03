using System.Collections.Generic;

public class CampTeamCreateUIMediator : MediatorBase
{
	public new const string NAME = "CampTeamCreateUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampTeamCreateUIMediator()
		: base(null)
	{
	}
}
