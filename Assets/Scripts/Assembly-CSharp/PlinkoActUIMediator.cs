using System.Collections.Generic;

public class PlinkoActUIMediator : MediatorBase
{
	public new const string NAME = "PlinkoActUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public PlinkoActUIMediator()
		: base(null)
	{
	}
}
