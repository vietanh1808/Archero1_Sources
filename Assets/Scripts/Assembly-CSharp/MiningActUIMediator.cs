using System.Collections.Generic;

public class MiningActUIMediator : MediatorBase
{
	public new const string NAME = "MiningActUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MiningActUIMediator()
		: base(null)
	{
	}
}
