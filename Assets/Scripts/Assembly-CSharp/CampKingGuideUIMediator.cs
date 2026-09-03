using System.Collections.Generic;

public class CampKingGuideUIMediator : MediatorBase
{
	public new const string NAME = "CampKingGuideUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampKingGuideUIMediator()
		: base(null)
	{
	}
}
