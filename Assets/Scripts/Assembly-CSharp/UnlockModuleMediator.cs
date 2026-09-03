using System.Collections.Generic;

public class UnlockModuleMediator : MediatorBase
{
	public new const string NAME = "UnlockModuleMediator";

	public override List<string> OnListNotificationInterests => null;

	public UnlockModuleMediator()
		: base(null)
	{
	}
}
