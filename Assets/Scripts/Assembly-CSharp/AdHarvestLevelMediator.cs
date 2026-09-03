using System.Collections.Generic;

public class AdHarvestLevelMediator : MediatorBase
{
	public new const string NAME = "AdHarvestLevelMediator";

	public override List<string> OnListNotificationInterests => null;

	public AdHarvestLevelMediator()
		: base(null)
	{
	}
}
