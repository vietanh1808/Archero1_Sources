using System.Collections.Generic;

public class AdHarvestShortMediator : MediatorBase
{
	public new const string NAME = "AdHarvestShortMediator";

	public override List<string> OnListNotificationInterests => null;

	public AdHarvestShortMediator()
		: base(null)
	{
	}
}
