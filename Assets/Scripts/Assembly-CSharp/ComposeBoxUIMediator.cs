using System.Collections.Generic;

public class ComposeBoxUIMediator : MediatorBase
{
	public new const string NAME = "BoxSelectUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ComposeBoxUIMediator()
		: base(null)
	{
	}
}
