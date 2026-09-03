using System.Collections.Generic;

public class TradingAchievementMediator : MediatorBase
{
	public new const string NAME = "TradingAchievementMediator";

	public override List<string> OnListNotificationInterests => null;

	public TradingAchievementMediator()
		: base(null)
	{
	}
}
