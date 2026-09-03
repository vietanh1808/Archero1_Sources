using System.Collections.Generic;

public class BoxSelectUIMediator : MediatorBase
{
	public new const string NAME = "BoxSelectUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BoxSelectUIMediator()
		: base(null)
	{
	}
}
