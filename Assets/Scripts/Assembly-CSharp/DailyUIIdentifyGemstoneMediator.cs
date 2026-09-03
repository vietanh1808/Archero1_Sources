using System.Collections.Generic;

public class DailyUIIdentifyGemstoneMediator : MediatorBase
{
	public new const string NAME = "IdentifyGemstoneMediator";

	public override List<string> OnListNotificationInterests => null;

	public DailyUIIdentifyGemstoneMediator()
		: base(null)
	{
	}
}
