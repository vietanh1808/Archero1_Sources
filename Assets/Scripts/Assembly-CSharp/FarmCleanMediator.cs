using System.Collections.Generic;

public class FarmCleanMediator : MediatorBase
{
	public new const string NAME = "FarmCleanMediator";

	public override List<string> OnListNotificationInterests => null;

	public FarmCleanMediator()
		: base(null)
	{
	}
}
