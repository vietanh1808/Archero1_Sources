using System.Collections.Generic;

public class ManorWorkerSelectUIMediator : MediatorBase
{
	public new const string NAME = "ManorWorkerSelectUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ManorWorkerSelectUIMediator()
		: base(null)
	{
	}
}
