using System.Collections.Generic;

public class ActBossPlayUIMediator : MediatorBase
{
	public new const string NAME = "ActBossPlayUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActBossPlayUIMediator()
		: base(null)
	{
	}
}
