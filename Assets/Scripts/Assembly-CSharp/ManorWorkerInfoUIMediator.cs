using System.Collections.Generic;

public class ManorWorkerInfoUIMediator : MediatorBase
{
	public new const string NAME = "ManorWorkerInfoUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorWorkerInfoUIMediator()
		: base(null)
	{
	}
}
