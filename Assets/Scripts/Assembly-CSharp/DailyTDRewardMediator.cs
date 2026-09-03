using System.Collections.Generic;

public class DailyTDRewardMediator : MediatorBase
{
	public new const string NAME = "DailyTDRewardMediator";

	public override List<string> OnListNotificationInterests => null;

	public DailyTDRewardMediator()
		: base(null)
	{
	}
}
