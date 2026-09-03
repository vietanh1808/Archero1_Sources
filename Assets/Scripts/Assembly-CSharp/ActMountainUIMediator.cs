using System.Collections.Generic;

public class ActMountainUIMediator : MediatorBase
{
	public new const string NAME = "ActMountainUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActMountainUIMediator()
		: base(null)
	{
	}
}
