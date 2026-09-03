using System.Collections.Generic;

public class CampGuideMediator : MediatorBase
{
	public new const string NAME = "CampGuideMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampGuideMediator()
		: base(null)
	{
	}
}
