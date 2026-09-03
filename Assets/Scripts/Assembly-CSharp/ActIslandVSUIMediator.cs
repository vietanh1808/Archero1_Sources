using System.Collections.Generic;

public class ActIslandVSUIMediator : MediatorBase
{
	public new const string NAME = "ActIslandVSUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActIslandVSUIMediator()
		: base(null)
	{
	}
}
