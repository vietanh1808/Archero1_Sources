using System.Collections.Generic;

public class SailingArenaBoxUIMediator : MediatorBase
{
	public new const string NAME = "SailingArenaBoxUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingArenaBoxUIMediator()
		: base(null)
	{
	}
}
