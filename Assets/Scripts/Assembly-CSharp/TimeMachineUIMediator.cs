using System.Collections.Generic;

public class TimeMachineUIMediator : MediatorBase
{
	public new const string NAME = "TimeMachineUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public TimeMachineUIMediator()
		: base(null)
	{
	}
}
