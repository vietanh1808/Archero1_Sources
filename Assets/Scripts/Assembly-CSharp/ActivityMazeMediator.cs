using System.Collections.Generic;

public class ActivityMazeMediator : MediatorBase
{
	public new const string NAME = "ActivityMazeMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActivityMazeMediator()
		: base(null)
	{
	}
}
