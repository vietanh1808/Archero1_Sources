using System.Collections.Generic;

public class SkyScraperTaskMediator : MediatorBase
{
	public new const string NAME = "SkyScraperTaskMediator";

	public override List<string> OnListNotificationInterests => null;

	public SkyScraperTaskMediator()
		: base(null)
	{
	}
}
