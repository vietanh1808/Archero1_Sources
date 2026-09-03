using System.Collections.Generic;

public class TradingHousePreviewUIMediator : MediatorBase
{
	public new const string NAME = "TradingHousePreviewUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public TradingHousePreviewUIMediator()
		: base(null)
	{
	}
}
