using System.Collections.Generic;

public class ActIslandVSBoxUIMediator : MediatorBase
{
	public new const string NAME = "ActIslandVSBoxUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActIslandVSBoxUIMediator()
		: base(null)
	{
	}
}
