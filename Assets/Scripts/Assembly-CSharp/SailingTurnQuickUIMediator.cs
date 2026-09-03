using System.Collections.Generic;

public class SailingTurnQuickUIMediator : MediatorBase
{
	public new const string NAME = "SailingTurnQuickUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingTurnQuickUIMediator()
		: base(null)
	{
	}
}
