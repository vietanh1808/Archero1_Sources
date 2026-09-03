using System.Collections.Generic;

public class SailingSalvageMediator : MediatorBase
{
	public new const string NAME = "SailingSalvageMediator";

	public override List<string> OnListNotificationInterests => null;

	public SailingSalvageMediator()
		: base(null)
	{
	}
}
