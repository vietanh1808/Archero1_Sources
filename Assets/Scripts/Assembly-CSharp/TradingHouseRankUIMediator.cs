using System.Collections.Generic;

public class TradingHouseRankUIMediator : MediatorBase
{
	public new const string NAME = "TradingHouseRankUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public TradingHouseRankUIMediator()
		: base(null)
	{
	}
}
