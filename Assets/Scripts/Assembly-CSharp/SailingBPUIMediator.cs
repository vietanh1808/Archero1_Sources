using System.Collections.Generic;

public class SailingBPUIMediator : MediatorBase
{
	public new const string NAME = "SailingBPUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingBPUIMediator()
		: base(null)
	{
	}
}
