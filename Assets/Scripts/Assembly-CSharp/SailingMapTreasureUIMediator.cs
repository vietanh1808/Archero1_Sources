using System.Collections.Generic;

public class SailingMapTreasureUIMediator : MediatorBase
{
	public new const string NAME = "SailingMapTreasureUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingMapTreasureUIMediator()
		: base(null)
	{
	}
}
