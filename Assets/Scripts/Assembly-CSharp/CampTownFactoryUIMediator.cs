using System.Collections.Generic;

public class CampTownFactoryUIMediator : MediatorBase
{
	public new const string NAME = "CampPreRewardUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampTownFactoryUIMediator()
		: base(null)
	{
	}
}
