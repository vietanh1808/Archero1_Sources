using System.Collections.Generic;

public class SailingArenaVSUIMediator : MediatorBase
{
	public new const string NAME = "SailingArenaVSUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingArenaVSUIMediator()
		: base(null)
	{
	}
}
