using System.Collections.Generic;

public class CampTeamAttrUIMediator : MediatorBase
{
	public new const string NAME = "CampTeamAttrUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampTeamAttrUIMediator()
		: base(null)
	{
	}
}
