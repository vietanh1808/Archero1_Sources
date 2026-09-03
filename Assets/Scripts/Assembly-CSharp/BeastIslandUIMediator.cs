using System.Collections.Generic;

public class BeastIslandUIMediator : MediatorBase
{
	public new const string NAME = "BeastIslandUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public BeastIslandUIMediator()
		: base(null)
	{
	}
}
