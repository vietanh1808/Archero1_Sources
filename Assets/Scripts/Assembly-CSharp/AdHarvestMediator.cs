using System.Collections.Generic;

public class AdHarvestMediator : MediatorBase
{
	public new const string NAME = "AdHarvestMediator";

	public override List<string> OnListNotificationInterests => null;

	public AdHarvestMediator()
		: base(null)
	{
	}
}
