using System.Collections.Generic;

public class CampPreRewardUIMediator : MediatorBase
{
	public new const string NAME = "CampPreRewardUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public CampPreRewardUIMediator()
		: base(null)
	{
	}
}
