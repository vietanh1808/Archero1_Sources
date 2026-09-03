using System.Collections.Generic;

public class PushPillarMediator : MediatorBase
{
	public new const string NAME = "PushPillarMediator";

	public override List<string> OnListNotificationInterests => null;

	public PushPillarMediator()
		: base(null)
	{
	}
}
