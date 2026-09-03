using System.Collections.Generic;

public class SkyScraperMediator : MediatorBase
{
	public new const string NAME = "SkyScraperMediator";

	public override List<string> OnListNotificationInterests => null;

	public SkyScraperMediator()
		: base(null)
	{
	}
}
