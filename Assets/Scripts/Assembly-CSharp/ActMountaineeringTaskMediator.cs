using System.Collections.Generic;

public class ActMountaineeringTaskMediator : MediatorBase
{
	public const string Name = "ActMountaineeringTaskMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActMountaineeringTaskMediator()
		: base(null)
	{
	}
}
