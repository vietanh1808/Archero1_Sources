using System.Collections.Generic;

public class CampTownLevelUIMediator : MediatorBase
{
	public new const string NAME = "CampPreRewardUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampTownLevelUIMediator()
		: base(null)
	{
	}
}
