using System.Collections.Generic;

public class MiningTaskUIMediator : MediatorBase
{
	public new const string NAME = "MiningTaskUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public MiningTaskUIMediator()
		: base(null)
	{
	}
}
