using System.Collections.Generic;

public class TradingHouseUIMediator : MediatorBase
{
	public new const string NAME = "TradingHouseUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public TradingHouseUIMediator()
		: base(null)
	{
	}
}
