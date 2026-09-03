using System.Collections.Generic;

public class PushPillarTaskMediator : MediatorBase
{
	public new const string NAME = "PushPillarTaskMediator";

	public override List<string> OnListNotificationInterests => null;

	public PushPillarTaskMediator()
		: base(null)
	{
	}
}
