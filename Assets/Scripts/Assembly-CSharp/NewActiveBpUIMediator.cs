using System.Collections.Generic;

public class NewActiveBpUIMediator : MediatorBase
{
	public new const string NAME = "NewActiveBpUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public NewActiveBpUIMediator()
		: base(null)
	{
	}
}
