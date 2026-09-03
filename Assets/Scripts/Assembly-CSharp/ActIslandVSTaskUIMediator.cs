using System.Collections.Generic;

public class ActIslandVSTaskUIMediator : MediatorBase
{
	public new const string NAME = "ActIslandVSTaskUIMediator";

	public override List<string> OnListNotificationInterests => null;

	public ActIslandVSTaskUIMediator()
		: base(null)
	{
	}
}
